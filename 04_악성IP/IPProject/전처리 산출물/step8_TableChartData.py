import pandas as pd

# CSV 파일 읽어오기
df = pd.read_csv('./outputs/step4_set_gps.csv')

# 필요한 열 결합
new_df = df[['Nc', 'AntiIp']]

# 'Nc' 열 기준으로 오름차순 정렬
sorted_df = new_df.sort_values(by='Nc', ascending=True)

# 새로운 CSV 파일로 저장
sorted_df.to_csv('./outputs/TableChartData.csv', index=False)
