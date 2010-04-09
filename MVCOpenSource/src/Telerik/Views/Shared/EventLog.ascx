<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<div class="event-log-wrap">
	<h3>Event log</h3>
	
	<a href="#" class="event-log-clear t-link"><span class="t-icon"></span>Clear log</a>
	
	<div class="event-log"></div>
</div>

<script type="text/javascript">
    //<![CDATA[

	window.$console = {
		log: function(msg) {
			$('<div />')
				.html(msg)
				.css({
					'margin-top': -24,
					'background-color': '#ffffd0'
				})
				.prependTo('.event-log')
				.animate({ marginTop: 0 }, 'fast')
				.animate({ backgroundColor: '#ffffff' }, 800);
		}
	};
	
	//]]>
</script>

<% Html.Telerik().ScriptRegistrar()
	   .OnDocumentReady(() => {%>
			$('.event-log-clear')
				.click(function(e) {
					e.preventDefault();
					$(this).next('.event-log').html('');
				});
	   <%});
%>