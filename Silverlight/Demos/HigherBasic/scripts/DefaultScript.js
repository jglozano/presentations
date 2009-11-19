var _dragging = false;
var _dx, _dy;
var videoMedia;

function Initialize(sender, args)
{
    videoMedia = sender.findName("videoMediaElement");
}

function onButtonDown(sender, args)
{
    var mousePos = args.GetPosition(null);
    
    _dx = mousePos.X - sender["Canvas.Left"];
    _dy = mousePos.Y - sender["Canvas.Top"];
    sender.captureMouse();
    _dragging = true;
}
 
function onButtonUp(sender, args)
{
    _dragging = false;
    sender.releaseMouseCapture();
}

function onMouseMove(sender, args)
{
    if (_dragging)
    {
        var mousePos = args.GetPosition(null);
        var x = mousePos.X - _dx;
        var y = mousePos.Y - _dy;
        
        sender["Canvas.Left"] = x;
        sender["Canvas.Top"] = y;
    }
}

function PlayVideo(sender, args)
{
    videoMedia.Play();	    
}

function PauseVideo(sender, args)
{
    videoMedia.Pause();	    
}

function StopVideo(sender, args)
{
    videoMedia.Stop();	    
}

function OnWeatherTextBlockClicked(sender, args)
{
    WeatherService.GetWeatherForecast("50111", OnWeatherComplete, OnError, sender);
}

function OnWeatherComplete(result, sender)
{
    sender.Text = result;
}

function OnPersonTextBlockClicked(sender, args)
{
    ComplexService.GetPerson(OnComplexComplete, OnError, sender);
}

function OnComplexComplete(result, sender)
{
    sender.Text = result.Name;
}

function OnError(reason, sender)
{
    sender.Text = reason;
}