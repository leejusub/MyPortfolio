import pandas as pd

# CSV 파일 읽어오기
df = pd.read_csv('./outputs/test6.csv')

# 국가코드 열을 기준으로 중복 행 제거
df.drop_duplicates(subset=['국가코드'], inplace=True)

# 새로운 CSV 파일로 저장
df.to_csv('./outputs/test6_1.csv', index=False)