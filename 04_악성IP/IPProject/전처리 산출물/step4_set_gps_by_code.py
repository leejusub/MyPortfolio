import pandas as pd
from datetime import datetime
from utils import measure_time, detect_encoding

def find_gps_info(code, gps_data :pd.DataFrame):
    # gps_data["Nc"][code]
    try:
        longitude = gps_data.loc[gps_data["Nc"] == code, "Lon"].values[0]
        latitude = gps_data.loc[gps_data["Nc"] == code, "Lat"].values[0]
        return (longitude, latitude)
    except:
        return (0,0)

@measure_time
def set_gps_data(file, column='Nc', column_lo="Lon", column_la="Lat", output='./outputs/step4_set_gps.csv'):
    data = pd.read_csv(file, encoding=detect_encoding(file))
    gps_data = pd.read_csv("./Raw_DATA/Geometry_new.csv", encoding=detect_encoding("./Raw_DATA/Geometry_new.csv"))
    for index, row in data.iterrows():
        gps = find_gps_info(row[column], gps_data)
        data.loc[index, column_lo] = gps[0]
        data.loc[index, column_la] = gps[1]
    data.to_csv(output, encoding='utf-8', index=False)


if __name__=="__main__":    
    file = "./outputs/step3_country_code.csv"
    set_gps_data(file)