#pragma checksum "C:\Users\atind\Downloads\Commercial_Adverts_Web_API\Commercial_Adverts_Web_API\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c703e7599005c5c00c670fc38cd14d5ab40d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c703e7599005c5c00c670fc38cd14d5ab40d26", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8c703e7599005c5c00c670fc38cd14d5ab40d262737", async() => {
                WriteLiteral("\n    <title>Commercials</title>\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8c703e7599005c5c00c670fc38cd14d5ab40d263956", async() => {
                WriteLiteral(@"

    <div>


        <button class=""btn btn-outline-dark"" data-toggle=""modal"" data-target=""#addAdvert"">Add Commercial</button>
        <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
            <div class=""carousel-inner"" id=""allAdverts"">

                <div class=""carousel-item col-lg-12 active"">
                    <div class=""card text-center"">
                        <div class=""card-header"">
                            Best Deals
                        </div>
                        <div class=""card-body"">
                            <h4 class=""card-title"">Deals for the holiday Season</h4>


                        </div>

                    </div>

                </div>
            </div>

            <a style=""height:25vh"" class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                <span class=""bg-primary carousel-control-prev-icon""></span>
                <span class=""sr-only"">Previous</span>
            </a>
    ");
                WriteLiteral(@"        <a style=""height:25vh"" class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                <span class=""bg-primary carousel-control-next-icon""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>







        <script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js""></script>
        <script src=""https://ajax.aspnetcdn.com/ajax/jquery.templates/beta1/jquery.tmpl.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
        <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
        <script>
            var uri = 'api/CommercialDeals';

            $(document).ready(function () {
        ");
                WriteLiteral(@"        // Gets Adverts
                $.getJSON(uri)
                    .done(function (data) {

                        $(""#adsTemp"").tmpl(data).appendTo(""#allAdverts"");
                    });
            });



            function getAdverts() {

                $.getJSON(uri)
                    .done(function (data) {

                        $(""#allAdverts"").text("""");
                        $(""#activeTemp"").tmpl([""s""]).appendTo(""#allAdverts"");

                        $(""#adsTemp"").tmpl(data).appendTo(""#allAdverts"");
                    });

            }

            function insertAdvert() {
                var _mainTitle = $('#mainTitle').val();
                var _description = $('#description').val();
                var _contact = $('#contact').val();




                var advert = {
                    mainTitle: _mainTitle,
                    description: _description,
                    contact: _contact


                };

                $.ajax({
                    type: ""POST"",
");
                WriteLiteral(@"                    url: uri,
                    data: JSON.stringify(advert),
                    contentType: ""application/json; charset=utf-8""
                }).done(function (response) {
                    $(""#result"").html(""Advert inserted"");
                    getAdverts();
                }).fail(function (jqXHR, textStatus) {
                    $(""#result"").html(""Error"");
                });




            }





            function updateAdvert() {
                var _mainTitle = $('#_mainTitle').val();
                var _description = $('#_description').val();
                var _contact = $('#_contact').val();




                var advert = {
                    id: parseInt($('#_id').val()),
                    mainTitle: _mainTitle,
                    description: _description,
                    contact: _contact


                };






                $.ajax({
                    type: ""PUT"",
                    url: uri + ""/"" + $('#_id').val(),
                    data: JSON.");
                WriteLiteral(@"stringify(advert),
                    contentType: ""application/json; charset=utf-8""
                }).done(function (response) {
                    $(""#resultUpdate"").html(""Updated Advert"");
                    getAdverts();
                }).fail(function (jqXHR, textStatus) {
                    $(""#resultUpdate"").html(""Error occured when updating"");
                });;




            }



            function remove(id) {


                var yes = confirm(""Discard this  Advert?"");

                if (yes) {
                    $.ajax({
                        type: ""DELETE"",
                        url: uri + ""/"" + id,

                    }).done(function (response) {

                        getAdverts();
                    });

                }


            }





            function displayAdvert(id) {

                $.ajax({
                    type: ""GET"",
                    url: uri + ""/"" + id,
                    contentType: ""application/json""
                }).done(function (res");
                WriteLiteral(@"ponse) {

                    $('#_id').val(response.id);
                    $('#_mainTitle').val(response.mainTitle);
                    $('#_description').val(response.description);
                    $('#_contact').val(response.contact);




                });


            }
        </script>



        <script id=""adsTemp"" type=""text/x-jquery-tmpl"">
            <div class=""carousel-item col-lg-12"">
                <div class=""card text-center"" style=""height:50vh"">
                    <div class=""card-header"">
                        Featured
                    </div>
                    <div class=""card-body"">
                        <h4 class=""card-title"">${mainTitle}</h4>
                        <p class=""card-text"">${description}</p>
                        <p class=""card-text"">For More Info Call ${contact}</p>

                    </div>
                    <div class=""card-footer text-muted"">
                        2 days ago
                    </div>
                </div>

                <");
                WriteLiteral(@"button class=""btn btn-outline-primary"" onclick=""displayAdvert('${id}')"" data-toggle=""modal"" data-target=""#updateAdvert"">Update</button>
                <a href=""#"" class=""btn btn-outline-danger"" onclick=""remove('${id}')"">Delete</a>
            </div>




        </script>

        <script id=""activeTemp"" type=""text/x-jquery-tmpl"">
            <div class=""carousel-item col-lg-12 active"">
                <div class=""card text-center"">
                    <div class=""card-header"">
                        Best Deals
                    </div>
                    <div class=""card-body"">
                        <h4 class=""card-title"">Deals for the holiday Season</h4>


                    </div>

                </div>

            </div>
    

    </script>
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""addAdvert"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Add Commercial</");
                WriteLiteral(@"h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <form>
                        <div class=""form-group"">
                            <label for=""name"">Title</label>
                            <input type=""text"" class=""form-control"" id=""mainTitle"" >

                        </div>
                        <div class=""form-group"">
                            <label for=""model"">Decription</label>
                            <input type=""text"" class=""form-control"" id=""description"">

                        </div>
                        <div class=""form-group"">
                            <label for=""model"">Contact Number</label>
                            <input type=""number"" class=""form-control"" id=""contact"">

                        </div>
                       

                   ");
                WriteLiteral(@"     <div class=""form-group"" id=""result"">


                        </div>
                        <button type=""button"" onclick=""insertAdvert()"" class=""btn btn-primary"">Publish Advert</button>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                </div>
            </div>
        </div>
    </div>




    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""updateAdvert"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Update</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <form>

                ");
                WriteLiteral(@"        <div class=""form-group"">

                            <input type=""hidden"" class=""form-control"" id=""_id"" aria-describedby=""emailHelp"">

                        </div>

                        <div class=""form-group"">
                            <label for=""name"">Title</label>
                            <input type=""text"" class=""form-control"" id=""_mainTitle"">

                        </div>
                        <div class=""form-group"">
                            <label for=""model"">Decription</label>
                            <input type=""text"" class=""form-control"" id=""_description"">

                        </div>
                        <div class=""form-group"">
                            <label for=""model"">Contact Number</label>
                            <input type=""number"" class=""form-control"" id=""_contact"">

                        </div>

                        <div class=""form-group"" id=""resultUpdate"">


                        </div>
                        <button type=""button"" oncli");
                WriteLiteral(@"ck=""updateAdvert()"" class=""btn btn-primary"">Update and Publish</button>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
