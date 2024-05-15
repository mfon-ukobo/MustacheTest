// See https://aka.ms/new-console-template for more information
using Mustache;

using MustacheTest;

var htmlText = await File.ReadAllTextAsync("index.html");

var htmlFormatCompiler = new HtmlFormatCompiler();
Generator generator = htmlFormatCompiler.Compile(htmlText);

var renderModel = new InvoiceGeneratorModel
{
	Invoice = new Invoice()
	{
		Items = [
			new InvoiceItem("Applicaiton for some item", 500),
			new InvoiceItem("Applicaiton for some other item", 4500),
		]
	},
	Company = new Company("Maxfront Technologies")
};

var newHtml = generator.Render(renderModel);

File.WriteAllText("generated.html", newHtml);