using System.Web.Http;
using System.Threading.Tasks;
using GroupDocs.Merger.Live.Demos.UI.Models;
using System;
using System.IO;
using GroupDocs.Merger.Domain.Result;
using GroupDocs.Merger.Handler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using GroupDocs.Conversion;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Contracts;

namespace GroupDocs.Merger.Live.Demos.UI.Controllers
{
	public class GroupDocsMergerController : ApiControllerBase
	{
		[HttpGet]
		[ActionName("MergeFile")]
		public async Task<Response> MergeFile(string fileName, string folderName, string sortOrder)
		{
			string logMsg = "ControllerName: GroupDocsMergerController FileName: " + fileName + " FolderName: " + folderName;
			string fileExt = Path.GetExtension(fileName).Substring(1).ToLower();

			try
			{
				return await ProcessTask(fileName, folderName, "." + fileExt, false, "", delegate (string inFilePath, string outPath, string zipOutFolder)
				{
					if (!Directory.Exists(zipOutFolder))
					{
						Directory.CreateDirectory(zipOutFolder);
					}
                    if (System.IO.File.Exists(outPath))
                    {
                        System.IO.File.Delete(outPath);
                    }

                    DirectoryInfo dir = System.IO.Directory.GetParent(inFilePath);
					FileInfo[] files = dir.GetFiles().OrderBy(p => p.Name).ToArray();
					List<Stream> documentStreams = new List<Stream>();

                    try
                    {
                        string[] arSortOrder = sortOrder.Split(',');
                        for (int i = 0; i < (arSortOrder.Length - 1); i++)
                        {
                            documentStreams.Add(new MemoryStream(System.IO.File.ReadAllBytes(files[Int32.Parse(arSortOrder[i]) - 1].FullName)));
                        }

                        DocumentResult result = new DocumentHandler().Join(documentStreams);
                        using (Stream documentStream = result.Stream)
                        {
                            using (var fileStream = System.IO.File.Create(outPath))
                            {
                                documentStream.CopyTo(fileStream);
                            }
                        }
                    }                   
                    finally
                    {                                               
                        foreach (Stream stream in documentStreams)
                        {
                            stream.Dispose();
                        }
                    }

                });
			}
			catch (Exception exc)
			{
				return new Response { FileName = fileName, FolderName = folderName, OutputType = fileExt, Status = exc.Message, StatusCode = 500, Text = exc.ToString() };
			}
		}

		private async Task<Response> ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip, string userEmail, ActionDelegate action)
		{
			try
			{
				return await Process2("GroupDocsMergerController", fileName, folderName, outFileExtension, createZip, action);
			}
			catch (Exception exc)
			{
				throw exc;
			}
		}

        [HttpGet]
        [ActionName("GetThumbnail")]
        public async Task<HttpResponseMessage> GetThumbnail(string fileName, string folderName)
        {
            var documentExtension = Path.GetExtension(fileName).TrimStart('.').ToLower();
            string inFilePath = AppSettings.WorkingDirectory + "/" + folderName + "/" + fileName;

            Task<HttpResponseMessage> result = Task.FromResult(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK
            });


            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {

                    SavePageStream getPageStream = page => memoryStream;

                    using (Converter converter = new Converter(inFilePath))                    
                    {
                        ImageConvertOptions options = new ImageConvertOptions
                        {
                            Format = ImageFileType.Png,
                            PageNumber = 1,
                            PagesCount = 1,
                            Pages = new List<int>() { 1 }
                        };

                        converter.Convert(getPageStream, options);
                    }

                    result.Result.Content = new ByteArrayContent(memoryStream.ToArray());
                    result.Result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                }
            }
            catch(Exception)
            {
                string tmpFileName = "tmp.txt";
                string filePath = AppSettings.WorkingDirectory + "/" + folderName + "/" + tmpFileName;
                if (!System.IO.File.Exists(filePath))
                {
                    System.IO.File.WriteAllText(filePath, " ");
                }

                result = GetThumbnail(tmpFileName, folderName);                
            }

            return await result;
        }
	}
}