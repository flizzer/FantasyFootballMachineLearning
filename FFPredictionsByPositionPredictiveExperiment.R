## Yet another test -- Set the workspace id

wsid = "paste your workspace id here within the quotation marks"

## Set the workspace authentication key

auth = "paste your authentication token here within the quotation marks "

## Input the name of the Experiment

serviceName = "paste your service’s name here within the quotation marks "

## Load the AzureML library if not previously installed: install.packages("AzureML")

library("AzureML")

## Create a reference to the workspace

ws <- workspace(wsid, auth)

## Create a reference to the experiment

s <- services(ws, name = serviceName)

## Send the dataset to the Azure ML web service for scoring and store the result in ds

ds <- consume(s, dataset)

## Aggregate the scores to a single value by month

scores <- data.frame(Prediction = tapply(ds$Scored.Labels, ds$Month_ID, sum))

## Aggregate the revenue to a single value by month (for comparison)

revenue <- data.frame(Actuals = tapply(ds$Revenue, ds$Month_ID, sum))

## Combine the two resulting vectors in the new data.frame timePlot

timePlot <- cbind(scores, revenue)

## Load the ggplot library if not previously installed: install.packages("ggplot2")

require(ggplot2)

## Specify the data to plot and set the x-axis

ggplot(data = timePlot, aes(x = 1:nrow(timePlot))) +

## Plot the two lines

geom_line(aes(y = Prediction, colour = 'Prediction')) +

geom_line(aes(y = Actuals, colour = 'Actuals')) +

## Rename the x and y axis

xlab("Time") +

ylab("Result $") +

## Name the legend

labs(colour = "Legend") +

## Change the colors of the line

scale_color_manual(values = c("green", "red"))