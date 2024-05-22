import pandas as pd
from utils import detect_encoding, measure_time

# 2024.04.26
# Geometry, Ipv4 컬럼명 변경하기 위해 RenameNc 먼저 실행하여 csv파일 새로저장
def ip_to_int(ip):
    # IP 주소를 '.'으로 분할하여 리스트로 변환
    octets = ip.split('.')
    # 각 옥텟을 정수로 변환하고 시프트 연산을 통해 합산
    ip_int = (int(octets[0]) << 24) + (int(octets[1]) << 16) + (int(octets[2]) << 8) + int(octets[3])
    return ip_int

@measure_time
def dataset_ip_to_int(file, col_name, new_col_name, output="./outputs/step2_ip_to_int.csv"):
    encoding = detect_encoding(file)
    data = pd.read_csv(file, encoding=encoding)
    for index, row in data.iterrows():
        ip = row[col_name]
        int_ip = ip_to_int(ip)
        data.loc[index, new_col_name] = int_ip
    data.to_csv(output, encoding='utf-8', index=False)
    
if __name__=="__main__":
    # 악성IP
    # file = "./outputs/step1_start_to_ip.csv"
    # column = "AntiIp"
    # new_column = "AntiIpAsInt"
    # output="./outputs/step2_ip_to_int.csv"
    # dataset_ip_to_int(file, column, new_column, output)

    # 국가할당 시작 IP
    # file = "./Raw_DATA/ipv4_new.csv"
    # column = "시작IP"
    # new_col = "SnIpAsInt"
    # output = "./outputs/step2-1_ipv4.csv"
    # dataset_ip_to_int(file, column, new_col, output)

    # 국가할당 끝 IP
    file = "./outputs/step2-1_ipv4.csv"
    column = "끝IP"
    new_col = "EnIpAsInt"
    output = "./outputs/step2-2_ipv4.csv"
    dataset_ip_to_int(file, column, new_col, output)
