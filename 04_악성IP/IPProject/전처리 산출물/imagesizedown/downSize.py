import os
from PIL import Image

targerdir = r"C:\Users\KB\Desktop\flag" #해당 폴더 설정

files = os.listdir(targerdir)

format = [".gif"] #지원하는 파일 형태의 확장자들
for (path,dirs,files) in os.walk(targerdir):
    for file in files:
         if file.endswith(tuple(format)):
             image = Image.open(path+"\\"+file)
             print(image.filename)
             print(image.size)

             image=image.resize((int(20), int(20)))
             image.save(path+"\\"+file)
             print(image.size)

         else:
             print(path)
             print("InValid",file)