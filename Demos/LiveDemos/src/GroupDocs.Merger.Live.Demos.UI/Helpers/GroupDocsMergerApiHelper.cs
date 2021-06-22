using GroupDocs.Merger.Live.Demos.UI.Models;
using GroupDocs.Merger.Live.Demos.UI.Config;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GroupDocs.Merger.Live.Demos.UI.Helpers
{
	public class GroupDocsMergerApiHelper
	{
		public static Response MergeFile(string fileName, string folderName, string sortOrder)
        {
			Response convertResponse = null;

			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                System.Threading.Tasks.Task taskUpload = client.GetAsync(Configuration.GroupDocsAppsAPIBasePath + "api/GroupDocsMerger/MergeFile?fileName=" + fileName 
                    + "&folderName=" + folderName + "&sortOrder=" + sortOrder).ContinueWith(task =>
				{
					if (task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
					{
						HttpResponseMessage response = task.Result;
						if (response.IsSuccessStatusCode)
						{
							convertResponse = response.Content.ReadAsAsync<Response>().Result;
						}
					}
				});

				taskUpload.Wait();
			}

			return convertResponse;
		}
		
	}
}