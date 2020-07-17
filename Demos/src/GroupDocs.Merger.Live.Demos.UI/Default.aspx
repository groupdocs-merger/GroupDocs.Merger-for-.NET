<%@ Page Title="Free online document merger for DOC, DOCX, PDF, XLSX, PPTX and other formats" MetaDescription="Merge documents in many formats, DOC, DOCX, PDF, XLSX, PPTX and other formats" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GroupDocs.Merger.Live.Demos.UI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <style>
                .preview-container.has-previews {
                    padding: 1px 1px 32px;
                    background-color: #f4f4f4;
                    border: 1px solid #ffffff;
                    border-bottom: none;
                    height: 100%;
                }

                .preview-container {
                    overflow: hidden;
                    margin-left: auto;
                    margin-right: auto;
                    margin-top: 30px;
                    margin-bottom: 30px;
                    display: -webkit-box;
                    display: -ms-flexbox;
                    display: flex;
                    -ms-flex-line-pack: start;
                    align-content: flex-start;
                    -webkit-box-pack: start;
                    -ms-flex-pack: start;
                    justify-content: flex-start;
                    -ms-flex-wrap: wrap;
                    flex-wrap: wrap;
                    -webkit-box-sizing: border-box;
                    box-sizing: border-box;
                }

                    .preview-container .preview-item {
                        -webkit-user-select: none;
                        -moz-user-select: none;
                        -ms-user-select: none;
                        user-select: none;
                        position: relative;
                        -webkit-box-sizing: border-box;
                        box-sizing: border-box;
                        width: 150px;
                        height: 175px;
                        margin: 0;
                        padding: 0;
                        -webkit-transition-property: color,background;
                        -o-transition-property: color,background;
                        transition-property: color,background;
                        -webkit-transition-duration: .2s;
                        -o-transition-duration: .2s;
                        transition-duration: .2s;
                    }

                        .preview-container .preview-item[draggable] {
                            cursor: move;
                        }

                        .preview-container .preview-item.dragging-item {
                            background-color: #ebebeb;
                            opacity: .4;
                        }

                        .preview-container .preview-item .img-preview-item {
                            position: relative;
                            width: 100%;
                            height: 100%;
                        }

                        .preview-container .preview-item .page {
                            width: 100%;
                            height: 100%;
                            background-repeat: no-repeat;
                            background-position: 50%;
                            background-size: 40px;
                        }











.preview-container .preview-item .filename, .preview-container .preview-item .page-info {
    display: block;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    position: absolute;
    bottom: 0;
    left: 0;
    width: 100%;
    height: 25px;
    line-height: 25px;
    overflow: hidden;
    -o-text-overflow: ellipsis;
    text-overflow: ellipsis;
    white-space: nowrap;
    text-align: center;
    font-weight: 400;
    font-size: 15px;
    line-height: 22px;
    color: #666;
    letter-spacing: .01em;
    padding: 0 10px;
}


            </style>

            <script>
                function drop(ev) {
                    ev.preventDefault();
                }

                function dragover(ev) {
                    ev.preventDefault();
                }

                function dragstart(ev) {
                    //ev.dataTransfer.setData("text", ev.target.id);        
                    ev.target.setAttribute("class", "preview-item dragging-item");
                    document.getElementById("txtDropSourceId").value = ev.target.id;
                }

                function dragend(ev) {
                    ev.target.setAttribute("class", "preview-item");
                    document.getElementById("txtDropSourceId").value = "";
                }

                function removediv(obj) {                                                                              
                    getRootElement(obj).remove();
                    getSortOrder();
                }

                function dragenter(ev) {

                    var sourceId = document.getElementById("txtDropSourceId").value;
                    if ((ev.target.id != "" && sourceId != "") && (ev.target.id != sourceId)) {

                        var sourceElement = getRootElement(document.getElementById(sourceId));
                        var targetElement = getRootElement(ev.target);
                        var parentElement = sourceElement.parentElement;

                        if (targetElement == parentElement.firstElementChild) {
                            parentElement.insertAdjacentElement("afterbegin", sourceElement);
                        }
                        else if (targetElement == parentElement.lastElementChild) {
                            parentElement.insertAdjacentElement("beforeend", sourceElement);
                        }
                        else if (targetElement.previousElementSibling == sourceElement) {
                            parentElement.insertBefore(sourceElement, targetElement.nextElementSibling);
                        }
                        else {
                            parentElement.insertBefore(sourceElement, targetElement);
                        }

                        getSortOrder();
                    }
                }

                function getRootElement(obj) {
                    var i = 6;
                    while ((i > 0) && (obj.getAttribute('draggable') != 'true')) {
                        obj = obj.parentElement;
                        i--;                        
                    }
                    return obj;
                }

                function getSortOrder() {
                    if (document.getElementById("<%=divPreview.ClientID%>") != null) {
                        var sortValue = "";
                        var divChildren = document.getElementById("<%=divPreview.ClientID%>").children;
                        var i;
                        for (i = 0; i < divChildren.length; i++) {
                            sortValue = sortValue + divChildren[i].id + ',';
                        }
                        document.getElementById("<%=txtSortOrder.ClientID%>").value = sortValue;
                    }
                }

                function TriggerFileUpload() {
                    $('#<%=btnUpload.ClientID %>').click();
                }

                function TriggerFileUpload2() {
                    $('#<%=btnUpload2.ClientID %>').click();
                }

                function ClickFileUpload() {
                    $('#<%=fileupload.ClientID %>').click();
                }

            </script>

            <div class="container-fluid GroupDocsApps">
                <div class="container">

                    <div class="row">
                        <div class="col-md-12 pt-5 pb-5">
                            <h1 id="hheading" runat="server">Free Online Document Merger</h1>
                            <h4 id="hdescription" runat="server">Merge <%=fileFormat  %>documents online from any device, with a modern browser like Chrome, Firefox</h4>
                            <div class="form">                                                    

                                <asp:PlaceHolder ID="ConvertPlaceHolder" runat="server">
                                    <div class="uploadfile">

                                        <div class="filedropdown">

                                            <p runat="server" id="pMessage"></p>
                                            <asp:HiddenField ID="hfToFormat" Value="~" runat="server" />

                                            <asp:PlaceHolder ID="FileDropPlaceHolder" runat="server">
                                                <div class="filedrop">
                                                    <label class="dz-message needsclick">Drop or select your files</label>
                                                    <input type="file" name="UploadFile" id="UploadFile" runat="server" class="uploadfileinput" multiple="multiple" onchange="TriggerFileUpload()" />
                                                    <asp:RegularExpressionValidator ID="ValidateFileType" ValidationExpression="([a-zA-Z0-9\s)\s(\s_\\.\-:])+(.doc|.docx|.dot|.dotx|.rtf)$"
                                                        ControlToValidate="UploadFile" runat="server" ForeColor="Red"
                                                        Display="Dynamic" />
                                                </div>
                                            </asp:PlaceHolder>
                                            
                                            <asp:PlaceHolder ID="PreviewPlaceHolder" runat="server" Visible="false">
                                                <div class="preview-container has-previews" runat="server" id="divPreview">
                                                </div>
                                                <div class="convertbtn">                                                                                                       
                                                    <input type="file" name="fileupload" id="fileupload" runat="server" onchange="TriggerFileUpload2()" Style="visibility: hidden"/>                                                                                                         
                                                    <label class="btn btn-success btn-lg" onclick="ClickFileUpload()">Add More</label>                                                    
                                                    <asp:Button runat="server" ID="btnUpload2" Text="UPLOAD" OnClick="btnUpload2_Click" Style="visibility: hidden" />                                                                                                        
                                                    <asp:Button runat="server" ID="btnMerge" class="btn btn-success btn-lg" Text="MERGE NOW" OnClick="btnMerge_Click" />                                                                                                        
                                                </div>
                                            </asp:PlaceHolder>

                                            <input type="hidden" value="" name="txtSortOrder" id="txtSortOrder" runat="server" />
                                            <input type="hidden" value="" name="txtFolderId" id="txtFolderId" runat="server" />
                                            <input type="hidden" value="" name="txtFileName" id="txtFileName" runat="server" />                                            
                                            <input type="hidden" value="" name="txtDivCount" id="txtDivCount" runat="server" />
                                            <input type="hidden" value="" id="txtDropSourceId" />
                                            <asp:Button runat="server" ID="btnUpload" Text="UPLOAD" OnClick="btnUpload_Click" Style="visibility: hidden" />


                                            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                                <ProgressTemplate>
                                                    <div>
                                                        <img height="59px" width="59px" alt="Please wait..." src="../../img/loader.gif" />
                                                    </div>
                                                </ProgressTemplate>
                                            </asp:UpdateProgress>
                                        </div>
                                    </div>
                                </asp:PlaceHolder>

                                <asp:PlaceHolder ID="DownloadPlaceHolder" runat="server" Visible="false">
                                    <div class="filesendemail">

                                        <div class="filesuccess">
                                            <label class="dz-message needsclick"><%=Resources["FileMergedSuccessMessage1"]%></label>
                                            <span class="downloadbtn convertbtn">
                                                <asp:Literal ID="litDownloadNow" runat="server"></asp:Literal>
                                            </span>
                                            <div class="clearfix">&nbsp;</div>
                                            <a href="" class="btn btn-link refresh-c"><%=Resources["MergeAnotherFile"]%> <i class="fa-refresh fa "></i></a>
                                            <a class="btn btn-link" target="_blank" href="https://products.groupdocs.cloud/merger/family">Cloud API &nbsp;<i class="fa-cloud fa"></i></a>
                                        </div>

                                        <p><%=Resources["SendTo"]%> </p>
                                        <div class="col-5 sendemail">
                                            <div class="input-group input-group-lg">
                                                <input type="email" id="emailTo" name="emailTo" class="form-control" placeholder="email@domain.com" runat="server" />
                                                <input type="hidden" id="downloadUrl" name="downloadUrl" runat="server" />
                                                <span class="input-group-btn">
                                                    <asp:LinkButton class="btn btn-success" type="button" ID="btnSend" runat="server" OnClick="btnSend_Click" Text="<i class='fa fa-envelope-o fa'></i>" />
                                                </span>
                                            </div>
                                        </div>
                                        <br />
                                        <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                            <ProgressTemplate>
                                                <div>
                                                    <img height="59px" width="59px" alt="Please wait..." src="../../img/loader.gif" />
                                                </div>
                                            </ProgressTemplate>
                                        </asp:UpdateProgress>
                                        <p runat="server" id="pMessage2"></p>
                                    </div>
                                </asp:PlaceHolder>


                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-12 pt-5 bg-gray tc" id="dvAllFormats" runat="server">
                <div class="container">
                    <div class="col-md-12 pull-left">
                        <h2 class="h2title">GroupDocs.Merger App</h2>
                        <p>GroupDocs.Merger App Supported Document Formats</p>
                        <div class="diagram1 d2 d1-net">
                            <div class="d1-row">
                                <div class="d1-col d1-left">
                                    <header>Microsoft Office Formats</header>
                                    <ul>
                                        <li><strong>Word:</strong> DOC, DOCM, DOCX, DOT, DOTX, DOTM, RTF‎</li>
                                        <li><strong>Excel:</strong> XLS, XLSX, XLSM, XLSB</li>
                                        <li><strong>PowerPoint:</strong> PPT, PPTX, PPS, PPSX</li>
                                        <li><strong>Visio:</strong> VSDX, VSDM, VSSX, VSSM, VTX, VSTM, VDX, VSTX, VSX</li>
                                        <li><strong>OneNote:</strong> ONE</li>
                                    </ul>
                                </div>
                                <!--/left-->


                                <div class="d1-col d1-right">
                                    <header>OpenDocument & Other Formats</header>
                                    <ul>
                                        <li><strong>OpenDocument Formats:</strong> ODT, OTT, ODP, OTP, ODS</li>
                                        <li><strong>Fixed Layout:</strong> PDF, XPS</li>
                                        <li><strong>Text:</strong> TXT, CSV</li>
                                        <li><strong>Other:</strong> EPUB</li>
                                    </ul>
                                </div>
                                <!--/right-->
                            </div>
                            <!--/row-->
                            <div class="d1-logo">
                                <img src="https://www.groupdocs.cloud/templates/groupdocs/images/product-logos/90x90-noborder/groupdocs-merger-net.png" alt=".NET Files Merger API"><header>GroupDocs.Merger</header>
                                <footer><small>App</small></footer>
                            </div>
                            <!--/logo-->
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-12 pull-left d-flex d-wrap bg-gray appfeaturesectionlist" id="dvFormatSection" runat="server" visible="false">
                <div class="col-md-6 cardbox tc col-md-offset-3 b6">
                    <h3 runat="server" id="hExtension1"></h3>
                    <p runat="server" id="hExtension1Description"></p>
                </div>
            </div>

            <div class="col-md-12 tl bg-darkgray howtolist">
                <div class="container tl dflex">
                    <div class="col-md-4 howtosectiongfx">
                        <img src="../../css/howto.png" />
                    </div>
                    <div class="howtosection col-md-8">
                        <div>
                            <h4><i class="fa fa-question-circle "></i><b>How to merge a <%=fileFormat  %>document using GroupDocs.Merger App</b></h4>
                            <ul>
                                <li>Select or drop your <%=fileFormat  %>documents for merging.</li>
                                <li>Once upload completes, drag <%=fileFormat  %>document thumbnails to rearrange them.</li>
                                <li>Click on <b>Merge Now</b> button to start merge process.</li>
                                <li>Once your <%=fileFormat  %>documents are merged click on <b>Download Now</b> button.</li>
                                <li>You may also send the download link to any email address by clicking on <b>Email</b> button.</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-12 pt-5 app-features-section">
                <div class="container tc pt-5">
                    <div class="col-md-4">
                        <div class="imgcircle fasteasy">
                            <img src="../../img/fast-easy.png" />
                        </div>
                        <h4><%= Resources["MergerFeature1"] %></h4>
                        <p><%= Resources["MergerFeature1Description"] %></p>
                    </div>

                    <div class="col-md-4">
                        <div class="imgcircle anywhere">
                            <img src="../../img/anywhere.png" />
                        </div>
                        <h4><%= Resources["MergerFeature2"] %></h4>
                        <p><%= Resources["Feature2Description"] %></p>
                    </div>

                    <div class="col-md-4">
                        <div class="imgcircle quality">
                            <img src="../../img/quality.png" />
                        </div>
                        <h4><%= Resources["MergerFeature3"] %></h4>
                        <p><%= Resources["PoweredBy"] %> <a runat="server" target="_blank" id="aPoweredBy"></a><%= Resources["QualityDescMetadata"] %></p>
                    </div>
                </div>
            </div>

            <script type="text/javascript">
                window.onsubmit = function () {
                    if (Page_IsValid) {
                        var updateProgress = $find("<%= UpdateProgress1.ClientID %>");
                        if (updateProgress) {
                            window.setTimeout(function () {
                                updateProgress.set_visible(true);
                                document.getElementById('<%= pMessage.ClientID %>').style.display = 'none';
                                document.getElementById('<%= pMessage2.ClientID %>').style.display = 'none';
                            }, 100);
                        }

                        var updateProgress2 = $find("<%= UpdateProgress2.ClientID %>");
                        if (updateProgress2) {
                            window.setTimeout(function () {
                                updateProgress2.set_visible(true);
                                document.getElementById('<%= pMessage.ClientID %>').style.display = 'none';
                                document.getElementById('<%= pMessage2.ClientID %>').style.display = 'none';
                            }, 100);
                        }
                    }
                }
            </script>
            <script>
                $(document).ready(function () {
                    bindEvents();
                });

                Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function (evt, args) {
                    bindEvents();
                });

                function bindEvents() {

                    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {

                        var swiper = new Swiper('.swiper-container', {
                            slidesPerView: 5,
                            spaceBetween: 20,
                            // init: false,
                            pagination: {
                                el: '.swiper-pagination',
                                clickable: true,
                            },
                            navigation: {
                                nextEl: '.swiper-button-next',
                                prevEl: '.swiper-button-prev',
                            },
                            breakpoints: {
                                868: {
                                    slidesPerView: 4,
                                    spaceBetween: 20,
                                },
                                668: {
                                    slidesPerView: 2,
                                    spaceBetween: 0,
                                }
                            }
                        });
                    }
                }

                getSortOrder();

            </script>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnUpload" />
            <asp:PostBackTrigger ControlID="btnMerge" />
            <asp:PostBackTrigger ControlID="btnUpload2" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
