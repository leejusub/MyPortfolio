import pandas as pd
# 24.04.29 json형태로 변환하기
import csv
import json

# CSV 파일 읽어오기
df = pd.read_csv('./outputs/step4_set_gps.csv')

# 국가코드별 AntiIp 갯수 계산
ip_counts = df.groupby('Nc')['AntiIp'].transform('count')

# 필요한 열과 IP주소 갯수 열 결합, AntiIp 열 제거
new_df = df[['Nc', 'Lon', 'Lat']].assign(Count=ip_counts)

# 국가코드 열을 기준으로 중복 행 제거
new_df.drop_duplicates(subset=['Nc'], inplace=True)

# 'Count' 열 기준으로 내림차순 정렬
sorted_df = new_df.sort_values(by='Count', ascending=False)

# Lat, Lon 소수점 1자리까지 반올림
sorted_df[['Lat','Lon']]=round(sorted_df[['Lat','Lon']], 1)

# 새로운 CSV 파일로 저장
sorted_df.to_csv('./outputs/WorldGraphData.csv', index=False)


# 24.04.29 json형태로 변환하기
# csv 파일 경로
csv_file_path = './outputs/WorldGraphData.csv'

# csv 파일 읽어오기
with open(csv_file_path, 'r', encoding='cp949') as f:
    reader = csv.reader(f)
    next(reader)  # 첫 줄 skip

    # 각 라인마다 딕셔너리 생성 후 리스트에 추가
    data = []
    for line in reader:
        d = {
            'Nc': line[0],
            'Lon': float(line[1]),
            'Lat': float(line[2]),
            'Count': int(line[3])
        }
        data.append(d)

# json string으로 변환
json_string = json.dumps(data, ensure_ascii=False, indent=2)

# print(json_string)

# txt 파일로 저장할 경로
txt_file_path = './outputs/WorldGraphData.txt'

# txt 파일 쓰기
with open(txt_file_path, 'w', encoding='utf-8') as f:
    f.write(json_string)