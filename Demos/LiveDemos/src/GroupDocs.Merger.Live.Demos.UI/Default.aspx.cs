using System;
using GroupDocs.Merger.Live.Demos.UI.Config;
using System.Web;
using GroupDocs.Merger.Live.Demos.UI.Models;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System.Xml;
using GroupDocs.Merger.Live.Demos.UI.Helpers;

namespace GroupDocs.Merger.Live.Demos.UI
{
    public partial class Default : BasePage
    {
        public string fileFormat = "";
        string logMsg = "";

        private string GetValidFileExtensions(string validationExpression)
        {
            string validFileExtensions = validationExpression.Replace(".", "").Replace("|", ", ").ToUpper();

            int index = validFileExtensions.LastIndexOf(",");
            if (index != -1)
            {
                string substr = validFileExtensions.Substring(index);
                string str = substr.Replace(",", " or");
                validFileExtensions = validFileExtensions.Replace(substr, str);
            }

            return validFileExtensions;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dvAllFormats.Visible = true;

                aPoweredBy.InnerText = "GroupDocs.Merger. "; ;
                aPoweredBy.HRef = "https://products.groupdocs.com/merger";

                string validationExpression = Resources["MergerValidationExpression"];
                if (Page.RouteData.Values["fileformat"] != null)
                {
                    validationExpression = "." + Page.RouteData.Values["fileformat"].ToString().ToLower();
                }
                string validFileExtensions = GetValidFileExtensions(validationExpression);
                ValidateFileType.ValidationExpression = @"(.*?)(" + validationExpression.ToLower() + "|" + validationExpression.ToUpper() + ")$";
                ValidateFileType.ErrorMessage = "Invalid file, please upload files with extension" + " " + validFileExtensions;

                UploadFile.Attributes.Add("accept", validationExpression.Replace('|', ','));
                fileupload.Attributes.Add("accept", validationExpression.Replace('|', ','));

                Page.Title = "Free online document merger for DOC, DOCX, PDF, XLSX, PPTX and other formats";
                Page.MetaDescription = "Merge documents in many formats, DOC, DOCX, PDF, XLSX, PPTX and other formats";
                if (Page.RouteData.Values["fileformat"] != null)
                {
                    hheading.InnerHtml = "Free Online  " + Page.RouteData.Values["fileformat"].ToString().ToUpper() + " Document Merger";
                    hfToFormat.Value = Page.RouteData.Values["fileformat"].ToString();

                    Page.Title = "Free Online  " + Page.RouteData.Values["fileformat"].ToString().ToUpper() + " Document Merger - GroupDocs.App";
                    Page.MetaDescription = "Merge " + Page.RouteData.Values["fileformat"].ToString().ToUpper() + " documents online for free";
                }
            }
        }

        protected void btnMerge_Click(object sender, EventArgs e)
        {
            Configuration.GroupDocsAppsAPIBasePath = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";
            Configuration.FileDownloadLink = Configuration.GroupDocsAppsAPIBasePath + "DownloadFile.aspx";

            if (IsValid && txtFolderId.Value != "")
            {
                divPreview.InnerHtml = GetSortedDivsHtml();

                try
                {
                    if(txtSortOrder.Value.Trim() == "" || txtSortOrder.Value.Split(',').Length < 3)
                    {
                        throw new Exception("Please select at least two files to merge together");
                    }

                    Response response = GroupDocsMergerApiHelper.MergeFile(txtFileName.Value, txtFolderId.Value, txtSortOrder.Value.Replace("div", ""));                    

                    if (response == null)
                    {
                        throw new Exception(Resources["APIResponseTime"]);
                    }
                    else if (response.StatusCode == 200)
                    {
                        string url = Configuration.FileDownloadLink + "?FileName=" + response.FileName + "&Time=" + DateTime.Now.ToString();
                        litDownloadNow.Text = "<a target=\"_blank\" href=\"" + url + "\" class=\"btn btn-success btn-lg\">" + Resources["DownLoadNow"] + " <i class=\"fa fa-download\"></i></a>";
                        downloadUrl.Value = HttpUtility.UrlEncode(url);

                        ConvertPlaceHolder.Visible = false;
                        DownloadPlaceHolder.Visible = true;

                        logMsg = "ControllerName: GroupDocsMergerController FileName: " + response.FileName + " FolderName: " + txtFolderId.Value + " OutFileExtension: " + "txt";
                    }
                    else
                    {
                        string msg = response.Status;

                        if (msg.ToLower().Contains("password"))
                        {
                            string asposeProduct = GetAsposeUnlockProduct(txtFileName.Value);
                            if (asposeProduct != null)
                            {
                                string asposeUrl = Configuration.ProductsGroupDocsAppsURL.ToLower().Replace("groupdocs", "aspose") + "/" + asposeProduct.ToLower() + "/unlock";
                                msg = "Your file seems to be encrypted. Please use our <a href=\"" + asposeUrl + "\">\"Unlock " + asposeProduct + "\"</a> app to remove the password.";
                            }
                        }

                        throw new Exception(msg);
                    }
                }
                catch (Exception ex)
                {
                    pMessage.InnerHtml = "Error: " + ex.Message;
                    pMessage.Attributes.Add("class", "alert alert-danger");
                }
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailTo.Value.Trim() == "")
                {
                    pMessage2.InnerHtml = Resources["MissingEmailMsg"];
                    pMessage2.Attributes.Add("class", "alert alert-danger");
                }
                else
                {
                    string url = HttpUtility.UrlDecode(downloadUrl.Value);
                    string emailBody = EmailManager.PopulateEmailBody(Resources["MergerEmailHeading"], url, Resources["FileMergedSuccessMessage1"]);
                    EmailManager.SendEmail(emailTo.Value, Configuration.FromEmailAddress, Resources["MergerEmailTitle"], emailBody, "");

                    pMessage2.Attributes.Add("class", "alert alert-success");
                    pMessage2.InnerHtml = Resources["FileMergerSuccessMessage"];
                }
            }
            catch (Exception ex)
            {
                pMessage2.InnerHtml = "Error: " + ex.Message;
                pMessage2.Attributes.Add("class", "alert alert-danger");
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            Configuration.GroupDocsAppsAPIBasePath = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";
            Configuration.FileDownloadLink = Configuration.GroupDocsAppsAPIBasePath + "DownloadFile.aspx";

            if (IsValid)
            {
                divPreview.InnerHtml = "";
                pMessage.InnerHtml = "";
                pMessage.Attributes.Add("class", "");

                bool errFlag = false;                
                if (Request.Files.Count > 0)
                {
                    string fileExt = Path.GetExtension(Request.Files[0].FileName).Substring(1).ToLower();
                    for (int i = 1; i < Request.Files.Count; i++)
                    {
                        if (Path.GetExtension(Request.Files[i].FileName).Substring(1).ToLower() != fileExt)
                        {
                            pMessage.InnerHtml = "Please upload files having same extension";
                            errFlag = true;
                            break;
                        }
                    }
                }

                if (!errFlag)
                {
                    try
                    {
                        FileUploadResult isFileUploaded = null;
                        string strHtml = "";
                        for (int i = 0; i < Request.Files.Count; i++)
                        {
                            string fn = Regex.Replace(System.IO.Path.GetFileName(String.Format("{0:D3}", (i + 1)) + "-" + Request.Files[i].FileName).Trim(), @"\A(?!(?:COM[0-9]|CON|LPT[0-9]|NUL|PRN|AUX|com[0-9]|con|lpt[0-9]|nul|prn|aux)|[\s\.])[^\\\/:*"" ?<>|]{ 1,254}\z", "");
                            string SaveLocation = Configuration.AssetPath + fn;
                            Request.Files[i].SaveAs(SaveLocation);

                            if (isFileUploaded == null)
                            {
                                isFileUploaded = FileManager.UploadFile(SaveLocation, "");
                            }
                            else
                            {
                                FileManager.UploadFileToFolder(SaveLocation, "", isFileUploaded.FolderId);
                            }

                            strHtml +=
                                    "<div class=\"preview-item\" draggable=\"true\" ondragend=\"dragend(event)\" ondragstart=\"dragstart(event)\" ondrop=\"drop(event)\" ondragover=\"dragover(event)\" ondragenter=\"dragenter(event)\" id=\"div" + (i + 1) + "\">"
                                        + "<div class=\"img-preview-item\">"
                                            + "<div class=\"page\">"
                                                + "<img id =\"drag" + (i + 1) + "\" src=\"" + Configuration.GroupDocsAppsAPIBasePath + "api/groupdocsmerger/getthumbnail?fileName=" + fn + "&amp;folderName=" + isFileUploaded.FolderId + "\" style =\"width:100%;height:auto;padding-right:2px;\"/>"
                                                + "<div><div><span class=\"filename\"><i class=\"fa fa-close\" onclick=\"removediv(this)\"></i>" + Regex.Replace(Request.Files[i].FileName.Trim(), @"\A(?!(?:COM[0-9]|CON|LPT[0-9]|NUL|PRN|AUX|com[0-9]|con|lpt[0-9]|nul|prn|aux)|[\s\.])[^\\\/:*"" ?<>|]{ 1,254}\z", "") + "</span></div></div>"
                                            + "</div>"
                                        + "</div>"
                                    + "</div>";
                        }

                        txtFolderId.Value = isFileUploaded.FolderId;
                        txtFileName.Value = isFileUploaded.FileName.Substring(isFileUploaded.FileName.IndexOf('-') + 1);
                        txtDivCount.Value = Request.Files.Count.ToString();

                        divPreview.InnerHtml = strHtml;

                        PreviewPlaceHolder.Visible = true;
                        FileDropPlaceHolder.Visible = false;

                    }
                    catch (Exception ex)
                    {
                        pMessage.InnerHtml = "Error: " + ex.Message;
                        pMessage.Attributes.Add("class", "alert alert-danger");
                    }
                }
                else
                {
                    pMessage.Attributes.Add("class", "alert alert-danger");
                }
            }
        }

        protected void btnUpload2_Click(object sender, EventArgs e)
        {
            Configuration.GroupDocsAppsAPIBasePath = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";
            Configuration.FileDownloadLink = Configuration.GroupDocsAppsAPIBasePath + "DownloadFile.aspx";

            if (IsValid)
            {
                divPreview.InnerHtml = GetSortedDivsHtml();
                pMessage.InnerHtml = "";
                pMessage.Attributes.Add("class", "");

                bool errFlag = false;

                string fileExt = Path.GetExtension(txtFileName.Value).Substring(1).ToLower();
                if (Path.GetExtension(Request.Files[0].FileName).Substring(1).ToLower() != fileExt)
                {
                    pMessage.InnerHtml = "Please upload files having same extension";
                    errFlag = true;
                }

                if (!errFlag)
                {
                    try
                    {                       
                        int i = Int32.Parse(txtDivCount.Value);
                        string strHtml = "";

                        string fn = Regex.Replace(System.IO.Path.GetFileName(String.Format("{0:D3}", (i + 1)) + "-" + Request.Files[0].FileName).Trim(), @"\A(?!(?:COM[0-9]|CON|LPT[0-9]|NUL|PRN|AUX|com[0-9]|con|lpt[0-9]|nul|prn|aux)|[\s\.])[^\\\/:*"" ?<>|]{ 1,254}\z", "");
                        string SaveLocation = Configuration.AssetPath + fn;
                        Request.Files[0].SaveAs(SaveLocation);

                        FileManager.UploadFileToFolder(SaveLocation, "", txtFolderId.Value);

                        strHtml +=
                                "<div class=\"preview-item\" draggable=\"true\" ondragend=\"dragend(event)\" ondragstart=\"dragstart(event)\" ondrop=\"drop(event)\" ondragover=\"dragover(event)\" ondragenter=\"dragenter(event)\" id=\"div" + (i + 1) + "\">"
                                    + "<div class=\"img-preview-item\">"
                                        + "<div class=\"page\">"
                                            + "<img id =\"drag" + (i + 1) + "\" src=\"" + Configuration.GroupDocsAppsAPIBasePath + "api/groupdocsmerger/getthumbnail?fileName=" + fn + "&amp;folderName=" + txtFolderId.Value + "\" style =\"width:100%;height:auto;padding-right:2px;\"/>"
                                            + "<div><div><span class=\"filename\"><i class=\"fa fa-close\" onclick=\"removediv(this)\"></i>" + Regex.Replace(Request.Files[0].FileName.Trim(), @"\A(?!(?:COM[0-9]|CON|LPT[0-9]|NUL|PRN|AUX|com[0-9]|con|lpt[0-9]|nul|prn|aux)|[\s\.])[^\\\/:*"" ?<>|]{ 1,254}\z", "") + "</span></div></div>"
                                        + "</div>"
                                    + "</div>"
                                + "</div>";


                        divPreview.InnerHtml += strHtml;
                        txtDivCount.Value = (i+1).ToString();

                    }
                    catch (Exception ex)
                    {
                        pMessage.InnerHtml = "Error: " + ex.Message;
                        pMessage.Attributes.Add("class", "alert alert-danger");
                    }
                }
                else
                {
                    pMessage.Attributes.Add("class", "alert alert-danger");
                }
            }
        }

        private string GetSortedDivsHtml()
        {
            string divsHtml = "";

            if (txtSortOrder.Value.Trim() != "")
            {
                string[] divs = txtSortOrder.Value.Substring(0, txtSortOrder.Value.Length - 1).Split(',');

                XmlDocument doc = new XmlDocument();
                doc.InnerXml = "<div>" + divPreview.InnerHtml + "</div>";
                for (int i = 0; i < divs.Length; i++)
                {
                    XmlNode node = doc.SelectSingleNode("//div[@id='" + divs[i] + "']");
                    divsHtml += node.OuterXml;
                }
            }

            return divsHtml;
        }

    }

    public class StringAsIntComparer : IComparer
    {
        public int Compare(object l, object r)
        {
            int left = Int32.Parse((string)l);
            int right = Int32.Parse((string)r);
            return left.CompareTo(right);
        }
    }
}