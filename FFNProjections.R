library(jsonlite)

apiKey <- "rixxmt4vxh6a"
weeklyRankingsCurrentWeekPprQbUrl <- sprintf("http://www.fantasyfootballnerd.com/service/weekly-rankings/json/%s/QB/''/1/",apiKey)
weeklyRankingsCurrentWeekPprQb <- fromJSON(weeklyRankingsCurrentWeekPprQbUrl)