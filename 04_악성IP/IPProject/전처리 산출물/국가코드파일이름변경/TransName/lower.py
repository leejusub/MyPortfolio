## 국가 코드 대문자를 소문자로 변환

import os

path="C:\\Users\\KB\\Desktop\\외교부_국가·지역별 국기 이미지"

file_list=os.listdir(path)

file_lists=[file for file in file_list if file.endswith(".png")]

for name in file_lists:
    src = os.path.join(path, name)
    print("src:", src)

    a = name
    k = a[1:2]
    s = k.lower()
    newname = src.replace(a[1:2], s)

    print("new:", newname)

    os.rename(src, newname)