#pragma checksum "D:\Proj\fictionsplash\Pages\Gosho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aff793204e70e1510a8f08206837a67896d29f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fictionsplash.Pages.Pages_Gosho), @"mvc.1.0.razor-page", @"/Pages/Gosho.cshtml")]
namespace fictionsplash.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Proj\fictionsplash\Pages\_ViewImports.cshtml"
using fictionsplash;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aff793204e70e1510a8f08206837a67896d29f4", @"/Pages/Gosho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79eb1e4f32662f6e89874d922fe6e10e6db17018", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Gosho : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: rgb(68, 68, 68);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\Proj\fictionsplash\Pages\Gosho.cshtml"
  
    ViewData["Title"] = "Gosho";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aff793204e70e1510a8f08206837a67896d29f43499", async() => {
                WriteLiteral("\r\n        <title>Гошо the snake</title>\r\n    ");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aff793204e70e1510a8f08206837a67896d29f44510", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h1 class=""center"" style=""color: cornsilk;"">
	Гошо змията алкохолик
</h1>

<canvas style=""display: block;"" class=""center"" tabindex=""-1"" id=""snakeBoard"" width=1000 height=600></canvas><br>
<span id=""vodkaSquare"" class=""vodka""></span>
<span id=""vodkaTip"">Водка (+1 скорост)</span> 
<span id=""meatSquare"" class=""meat""></span>
<span id=""meatTip"">Мезе (+1 дължина)</span>

<style>
    #trademark {
        margin-top: 1000px;
    }
    #snakeBoard {
        border:10px solid rgb(111, 212, 9);
        background-color: ""gray"";
    }
    #vodkaSquare {
        margin-left:430px; 
        margin-top:20px
    }
    #vodkaTip {
        margin-left:5px;
        color: cornsilk;
    }
    #meatSquare {
        margin-left:15px; 
        margin-top:20px;
    }
    #meatTip {
        margin-left:5px;
        color: cornsilk;
    }
    .vodka{
		display: inline-block;
		width: 20px;
		height: 20px;
		background-color: rgb(0,255,255);
	}
	.meat{
		display: inline-block;
		width: 20px;");
            WriteLiteral(@"
		height: 20px;
		background-color: rgb(212,102,121);
	}
    .center{
        margin-left: auto;
        margin-right: auto;
        text-align: center;
    }
    .alignedLeft{
        text-align: left;
    }
    .alignedRight{
        text-align: right;
    }
</style>

<script>	
	var canvas = document.getElementById(""snakeBoard"");
    var context = canvas.getContext(""2d"");
    document.addEventListener(""keydown"", ChangeDirection);

    goshoColor = ""#0b8fe8""
    goshoBoarderColor = ""#39db61""

    let gosho = [ 
        {x: 200, y: 200}, 
        {x: 190, y: 200}, 
        {x: 180, y: 200}, 
        {x: 170, y: 200}, 
        {x: 160, y: 200}
    ]
    let dx = 10;
    let dy = 0;

    let meats = []

    let vodkaBottles = []

    let vodkaCount = 0;
    
    var speed = 100;

    for(let i = 0;i < 3; i++)
    {
        GenerateNewVodka()
        GenerateNewMeat()
    }
    
    Main()

    function Main() {
        setTimeout(function onTick()
        {
");
            WriteLiteral(@"            ClearCanvas();
            MoveSnake();
            DrawSnake();
            if(HasDied())
                DeathMessage()
            else
                Main();
        }, speed)    
    }

    function DrawSnakePart(snakePart)
    {
        context.fillStyle = goshoColor;
        context.strokeStyle = goshoBoarderColor;
        context.fillRect(snakePart.x, snakePart.y, 10, 10);
        context.strokeRect(snakePart.x, snakePart.y, 10, 10);
    }
    
    function DrawSnake()
    {
        gosho.forEach(DrawSnakePart);
    }

    function ClearCanvas() {
        context.fillStyle = ""gray""
        context.strokeStyle = ""lime""
        context.fillRect(0,0, canvas.width, canvas.height)
        context.strokeRect(0,0, canvas.width, canvas.height)
        
        context.fillStyle = ""#d46679""  
        meats.forEach(meat => context.fillRect(meat.x, meat.y, 10, 10,))

        context.fillStyle = ""#00ffff""
        vodkaBottles.forEach(vodka => context.fillRect(vodka.x,");
            WriteLiteral(@" vodka.y, 10, 10,))
    }

    function MoveSnake() 
    {
        const headNow = gosho[0];
        const head = {x: headNow.x + dx, y: headNow.y + dy};

        if(ElementsCollide(headNow, meats))
        {
            gosho.unshift(head)

            RemoveAllMeat()
            GenerateNewMeat()
        }
        else if(ElementsCollide(headNow, vodkaBottles))
        {
            speed-=5;
            vodkaCount++;

            gosho.unshift(head);
            gosho.pop();
            RemoveAllVodka()
            GenerateNewVodka()
        }
        else
        {   
            gosho.unshift(head);
            gosho.pop();
        }
    }

    function ChangeDirection(event) 
    {
        const LEFT_KEY = 37;
        const RIGHT_KEY = 39;
        const UP_KEY = 38;
        const DOWN_KEY = 40;
        const SPACE_KEY = 32;
 
        var keyPressed = event.keyCode;
        var goingUp = dy === -10;
        var goingDown = dy === 10;
        var goingRight = dx ");
            WriteLiteral(@"=== 10;  
        var goingLeft = dx === -10;
 
        if (keyPressed === LEFT_KEY && !goingRight)
        {    
            dx = -10;
            dy = 0;  
        }
    
        if (keyPressed === UP_KEY && !goingDown)
        {    
            dx = 0;
            dy = -10;
        }
    
        if (keyPressed === RIGHT_KEY && !goingLeft)
        {    
            dx = 10;
            dy = 0;
        }
    
        if (keyPressed === DOWN_KEY && !goingUp)
        {    
            dx = 0;
            dy = 10;
        }

        if (keyPressed === SPACE_KEY && HasDied())
        {
            RestartGame();
        }
    }

    function HasDied()
    {
        head = gosho[0];
        
        for (let i = 1; i < gosho.length; i++)
        {
            const hasColided = head.x === gosho[i].x && head.y === gosho[i].y;
            
            if(hasColided)
            {
                return true;
            }
        }

        let hitLeftWall = head.x < ");
            WriteLiteral(@"0;
        let hitRightWall = head.x > canvas.width - 10;
        let hitTopWall = head.y < 0;
        let hitDownWall = head.y > canvas.height - 10;

        if(hitLeftWall || hitRightWall || hitTopWall || hitDownWall)
        {
            return true;
        }    
    }

    function DeathMessage()
    {
        context.font = ""30px Arial""
        context.fillStyle = ""red""
        context.fillText(""Гошо умря от цироза"", 350, 200);

        context.fillStyle = ""white""
        context.fillText(""Натисни \""space\"""", 380, 300)

        context.fillStyle = ""white""
        context.fillText(""Резултат: ""+ gosho.length * vodkaCount, 350, 400)
    }
    
    function RestartGame()
    {
        gosho = [ 
        {x: 200, y: 200}, 
        {x: 190, y: 200}, 
        {x: 180, y: 200}, 
        {x: 170, y: 200}, 
        {x: 160, y: 200}
        ]
        
        dx = 10;
        dy = 0;

        speed = 100;

        RemoveAllMeat();
        GenerateNewMeat();
        RemoveA");
            WriteLiteral(@"llVodka();
        GenerateNewVodka();
        Main();
    }

    function GenerateNewMeat()
    {
        var randomX = Math.floor(Math.random() * 971)
        var randomY = Math.floor(Math.random() * 571)

        var meat = {x: randomX, y: randomY}

        if(ElementsCollide(meat, gosho)
        || ElementsCollide(meat, vodkaBottles)
        || meat.x % 10 !== 0 
        || meat.y % 10 !== 0)
        {
            GenerateNewMeat()
        }
        else
        {
            meats.unshift(meat)
        }

    }

    function RemoveAllMeat()
    {
        for(let i = 0; i < meats.length; i++)
        {
            meats.pop()
        }
    }

    function GenerateNewVodka()
    {
        var randomX = Math.floor(Math.random() * 971)
        var randomY = Math.floor(Math.random() * 571)

        var vodka = {x: randomX, y: randomY}

        if(ElementsCollide(vodka, gosho)
        || ElementsCollide(vodka, meats)
        || vodka.x % 10 !== 0 
        || vodka.y ");
            WriteLiteral(@"% 10 !== 0)
        {
            GenerateNewVodka()
        }
        else
        {
            vodkaBottles.unshift(vodka)
        }
    }

    function RemoveAllVodka()
    {
        for(let i = 0; i < vodkaBottles.length; i++)
        {
            vodkaBottles.pop()
        }
    }

    function ElementsCollide(object, collection)
    {
        for(let i = 0; i < collection.length; i++)
        {
            if(JSON.stringify(collection[i]) === JSON.stringify(object))
            {
                return true
            }
        }
        return false
    }

    function FindCollision(collection1, collection2)
    {
        for(let i = 0; i < collection1.length; i++)
        {
            for(let j = 0; j < collection2.length; j++)
            {
                if(JSON.stringify(collection1[i]) === JSON.stringify(collection2[j]))
                {
                    return collision = {x: collection1[i].x, y: collection1[i].x};
                }
            }
");
            WriteLiteral("        }\r\n        return 0;\r\n    }\r\n</script>\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoshoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GoshoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GoshoModel>)PageContext?.ViewData;
        public GoshoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
