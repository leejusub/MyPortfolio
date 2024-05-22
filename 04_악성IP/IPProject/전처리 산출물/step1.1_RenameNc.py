import pandas as pd
from utils import detect_encoding

# Geometry.csv 파일 읽어오기
geometry_df = pd.read_csv("./Raw_DATA/Geometry.csv", encoding=detect_encoding("./Raw_DATA/Geometry.csv"))

# 열 이름 확인
print(geometry_df.columns)

# 열 이름 변경
geometry_df.rename(columns={'국가코드': 'Nc', 'Longitude':'Lon', 'Latitude':'Lat'}, inplace=True)

# 변경된 열 이름 확인
print(geometry_df.columns)

# 변경된 DataFrame을 새로운 CSV 파일로 저장
geometry_df.to_csv("./Raw_DATA/Geometry_new.csv", index=False)

# ipv4.csv 파일 읽어오기
ipv4_df = pd.read_csv("./Raw_DATA/ipv4.csv", encoding=detect_encoding("./Raw_DATA/ipv4.csv"))
# 열 이름 확인
print(geometry_df.columns)
# 열 이름 변경
ipv4_df.rename(columns={'국가코드': 'Nc'}, inplace=True)
# 변경된 열 이름 확인
print(geometry_df.columns)
# 파일 저장
ipv4_df.to_csv("./Raw_DATA/ipv4_new.csv", index=False)
