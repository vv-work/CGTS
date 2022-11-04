import os

path = ".//res//CheetSheets"

dirs = os.listdir(path)
for f in dirs:
    print("![%s](./res/CheetSheets/%s)"%(f,f))
   
