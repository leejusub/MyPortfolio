import pandas as pd
# 24.04.29 json형태로 변환하기
import csv
import json

# CSV 파일 읽어오기
df = pd.read_csv('./outputs/WorldGraphData.csv')

# 필요한 열과 IP주소 갯수 열 결합, AntiIp 열 제거
new_df = df[['Nc', 'Count']]

# 파일로 저장
new_df.to_csv('./outputs/PieChartData.csv', index=False)

# 24.04.29 json형태로 변환하기
# csv 파일 경로
csv_file_path = './outputs/PieChartData.csv'

# csv 파일 읽어오기
with open(csv_file_path, 'r', encoding='cp949') as f:
    reader = csv.reader(f)
    next(reader)  # 첫 줄 skip

    # 각 라인마다 딕셔너리 생성 후 리스트에 추가
    data = []
    for line in reader:
        d = {
            'Nc': line[0],
            'Count': int(line[1])
        }
        data.append(d)

# json string으로 변환
json_string = json.dumps(data, ensure_ascii=False, indent=2)

# print(json_string)

# txt 파일로 저장할 경로
txt_file_path = './outputs/PieChartData.txt'

# txt 파일 쓰기
with open(txt_file_path, 'w', encoding='utf-8') as f:
    f.write(json_string)