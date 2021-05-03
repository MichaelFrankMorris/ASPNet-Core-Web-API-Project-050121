This project is a very straight-forward demo with a few minor changes:

Project Start:
1) No Authorization.  This project is primarily for demo purposes, and I'm familiar with Authorization.  
I may start a separate project from scratch, and republish with authorization just for fun.  I wanted to concentrate on other areas 
though in this particular demo.

Changes:
1) WeatherForecast.cs 
Changed the Fahrenheit/Celsius conversion to remove the 'inaccuracy' of (/.5556) ... which does not cause a
problem in this code, but might cause some misinterpretation by someone viewing the code.
2) WeatherForecastController.cs
Converted the data output from being completely random.  Random number generation is certainly a choice one could make, but this produces
text Summaries (a.k.a. descriptions of how the weather feels) "Scorching", "Freezing" that were completely unrelated to predicted temperatures.  30F might be "Scorching", 
and 100F "Freezing".  Also the temperature progression over 5-days ... each day was completely unrelated to adjacent days.  Temperatures could be 32, 100, 32, 100, 32...
a truly ridiculous temperature sequence.  Theoretically possible on Earth, but pretty much apocolyptic conditions.
	a) Tied the temperature ranges to 'Summaries'.  Avoids the 100F == "Freezing" issue.
	b) Built a List<WeatherForecast>, populate List so that temperatures are in a reasonable sequence.  Avoids the 32, 100, 32 issue.
	c) Change the forecast to 7 days rather than 5.
	d) Other minor changes.

Other thoughts:
1) Ideally, I would at least convert "Summaries" into a SQL table with temperature ranges.  Right now if someone added a new description/Summary in the array, they would
have to remember to modify other lines in the Controller.  
2) Several "Summaries" entries may depend on humidity.  Expand all to include humidity if an accurate representation of "Summaries" (description) is actually important.
3) Expand to grab actual weather forecasts from another site or app.  
4) At least read the current temperature (and humidity), be aware of season, longitude, typical weather
patterns, and make predictions based on current and previous data.
5) Tap into at least one actual (already existent) weather model.  