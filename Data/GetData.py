class Data:
    class Trial:
        def __init__(self):
            self.rawData = {}
            self.numberOfClicks = {}
            self.timeOfClicks = {}
            self.time = 0
            self.totalClicks = 0

    def __init__(self, filename):
        self.trials = []
        self.filename = filename
        for i in range(7):
            newTrial = self.Trial()
            self.trials.append(newTrial)
        self.parseData(filename)

    def parseData(self, filename):
        trial = 0
        with open(filename) as f:
            for line in f:
                if line == "\n":
                    continue
                button, time = self.parseLine(line)
                if button in self.trials[trial].rawData:
                    self.trials[trial].rawData[button].append(time)
                else:
                    self.trials[trial].rawData[button] = [time]
                if button == "TaskFinished":
                    trial += 1
        self.setOtherData()

    def parseLine(self, line):
        button, time = line.split(",", 1)
        time = time.strip()
        return button, float(time)

    def setOtherData(self):
        self.setClicks()
        self.setTimeOfClicks()
        self.setTime()
        self.setTotalClicks()

    def setClicks(self):
        for trial in self.trials:
            data = trial.rawData
            for key in data:
                trial.numberOfClicks[key] = len(data[key])

    def setTotalClicks(self):
        for trial in self.trials:
            totalClicks = 0
            data = trial.numberOfClicks
            for key in data:
                totalClicks += data[key]
            trial.totalClicks = totalClicks - 2

    def setTimeOfClicks(self):
        for trial in self.trials:
            startTime = 0
            data = trial.rawData
            for key in data:
                if key == "start":
                    startTime = data[key][0]
                trial.timeOfClicks[key] = [x - startTime for x in data[key]]

    def setTime(self):
        for trial in self.trials:
            trial.time = trial.timeOfClicks["TaskFinished"][0]

    def printData(self):
        participantID, tutType, _ = self.filename.split("_", 2)
        # tutType = tutType.strip('_')
        stringData = "Participant,{ID}\nType,{tut}\n\n".format(ID=participantID, tut=tutType)
        stringData += self.timeString()
        stringData += self.buttonTimeToString()
        stringData += self.buttonClickToString()
        return stringData
    
    def timeString(self):
        clicksString = "Trial total time and number of clicks\n"
        trialNumOne = 1
        trialNumTwo = 1
        for trial in self.trials:
            clicksString += "Trial {numOne}.{numTwo}\n".format(numOne=trialNumOne, numTwo=trialNumTwo)
            clicksString += "Time,{t:.4f}\n".format(t=trial.time)
            clicksString += "Total Clicks,{c}\n".format(c=trial.totalClicks)
            if trialNumTwo == 3:
                trialNumTwo = 1
                trialNumOne += 1
            else:
                trialNumTwo += 1
            clicksString += "\n"
        return clicksString
    
    def buttonClickToString(self):
        clicksString = "Number of Clicks Per Button\n"
        trialNumOne = 1
        trialNumTwo = 1
        for trial in self.trials:
            clicksString += "Trial {numOne}.{numTwo}\n".format(numOne=trialNumOne, numTwo=trialNumTwo)
            for button in trial.numberOfClicks:
                clicksString += "{b},{n}\n".format(b=button, n=trial.numberOfClicks[button])
            if trialNumTwo == 3:
                trialNumTwo = 1
                trialNumOne += 1
            else:
                trialNumTwo += 1
            clicksString += "\n"
        return clicksString

    def buttonTimeToString(self):
        clicksString = "Time of Clicks per Button\n"
        trialNumOne = 1
        trialNumTwo = 1
        for trial in self.trials:
            clicksString += "Trial {numOne}.{numTwo}\n".format(numOne=trialNumOne, numTwo=trialNumTwo)
            for button in trial.timeOfClicks:
                buttonTimes = trial.timeOfClicks[button]
                timesString = ""
                for time in buttonTimes:
                    timesString += ",{t:.4f}".format(t=time)
                clicksString += "{b}{times}\n".format(b=button, times=timesString)
            if trialNumTwo == 3:
                trialNumTwo = 1
                trialNumOne += 1
            else:
                trialNumTwo += 1
            clicksString += "\n"
        return clicksString
    
    def saveToFile(self, filename):
        with open(filename, "w") as f:
            f.write(self.printData())
        

