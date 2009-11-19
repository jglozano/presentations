function createSilverlight()
{
	var scene = new Basics.Page();
	Silverlight.createObjectEx({
		source: "Page.xaml",
		parentElement: document.getElementById("SilverlightControlHost"),
		id: "SilverlightControl",
		properties: {
			width: "100%",
			height: "100%",
			version: "1.0"
		},
		events: {
			onLoad: Silverlight.createDelegate(scene, scene.handleLoad)
		}
	});
}


if (!window.Silverlight) 
	window.Silverlight = {};

Silverlight.createDelegate = function(instance, method) {
	return function() {
		return method.apply(instance, arguments);
	}
}

function OnButtonDown(sender, args)
    {
        sender.Width += 10;
        sender.Height += 10;
    }
