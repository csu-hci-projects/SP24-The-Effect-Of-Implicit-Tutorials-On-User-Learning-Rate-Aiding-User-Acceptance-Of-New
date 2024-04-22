from GetData import Data
import os, glob

#path must stay rawData/ - its expected by the Data class
path = "rawData/"

for filename in glob.glob(os.path.join(path, "*.txt")):
    participant = Data(filename)
    participant.saveToFile("participantData/participant{num}.csv".format(num=participant.participant))