import requests, json
import urllib.request #json api 가져오기
from flask import Flask,request,jsonify,abort
import sys
application = Flask(__name__)


@application.route("/")
def hello():
    return "Hello goorm!"

@application.route("/a")
def helloa():
    return "Hello goorma!"

# 개발자도구->챗봇api설정->webhook
@application.route("/navertalk", methods=['POST'])
def mytalk():
    #print('request')
    #print(request)
    
    print('request get json')
    print(request.get_json()) # 이걸로 찍어봐야 한다.
    
    # 개발자도구->챗봇api설정->webhook
    authorization_key = '5YlPTtw4SrqjmQXLieja'
    
    headers = {
        'Content-Type' : 'application/json;charset=UTF-8',
        'Authorization' : authorization_key
    }

    """
        {'event': 'send', 'user': 'LkUTPa3r7TiF_hqymXT8AQ', 'messageId': 39, 'textContent': {'text': 'aslkdfjslakdjflkasjdflsjdlfsd', 'inputType': 'typin
    g'}, 'options': {'noReflectBot': False, 'mobile': False}}
    
    {'event': 'send', 'user': 'LkUTPa3r7TiF_hqymXT8AQ', 'messageId': 54, 'textContent': {'text': 'ㅁㄴㅇㅁㄴㅇㅁㅇㅁㄴㅇ', 'inputType': 'typing'}, 'o
ptions': {'noReflectBot': False, 'mobile': False}}


    """
    getReqJson = request.get_json()
    print('getReqJson : %s' % getReqJson)
    #print('user_key : '.join( getReqJson['user']))
    print('user_key : %s' % ( getReqJson['user']))
    user_key = getReqJson['user']
    #user_key = 'LkUTPa3r7TiF_hqymXT8AQ'
    '''data = {
        'event' : 'send',
        'user':user_key,
        'textContent':{'text':'Hello World!'}
    }
    '''
    
    '''
    {"totSellamnt":81032551000,"returnValue":"success","drwNoDate":"2019-06-01","firstWinamnt":4872108844,"drwtNo6":25,"drwtNo4":21,"firstPrzwnerCo":4,"drwtNo5":22,"bnusNo":24,"firstAccumamnt":19488435376,"drwNo":861,"drwtNo2":17,"drwtNo3":19,"drwtNo1":11}
    
    '''
    
    userMsg = getReqJson['textContent']['text']
    isImg = True
    lottodata=''
    if userMsg.split()[0]=='로또':
        isImg = False
        url = 'https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=%s'% userMsg.split()[1]
        response = urllib.request.urlopen(url)
        response_message = response.read().decode('utf8')
        jresponse = json.loads(response_message)
        print(jresponse)
        print(response_message)
        print(jresponse['returnValue'])
        
        if jresponse['returnValue'] != 'success':
            lottodata = '잘못된 입력입니다.'
            print(lottodata)
        else:
            lottodata = "{} {} {} {} {} {} 보너스 : {}".format(jresponse['drwtNo1'],jresponse['drwtNo2'],jresponse['drwtNo3'],jresponse['drwtNo4'],jresponse['drwtNo5'],jresponse['drwtNo6'],jresponse['bnusNo'])   
            print(lottodata)
    else:
        img = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Naver_Logotype.svg/1280px-Naver_Logotype.svg.png"
        if userMsg.upper()=='GOOGLE':
                img = 'https://www.google.com/logos/doodles/2022/seasonal-holidays-2022-6753651837109831.4-s.png'
        elif userMsg.upper()=='DAUM' or userMsg.upper()=='KAKAO':
                img = 'https://t1.kakaocdn.net/kakaocorp/corp_thumbnail/Kakao.png'

    if isImg==True:
        data = {
            'event':"send",
            'user':user_key,
            "imageContent" : {
                "imageUrl":img
            }
        }
    else :
        data = {
            'event':"send",
            'user':user_key,
            'textContent':{
                "text":lottodata
            }
            }


    message = json.dumps(data)
    response = requests.post('https://gw.talk.naver.com/chatbot/v1/event',
                            headers=headers,
                            data=message)


if __name__ == "__main__":
    application.run(host='0.0.0.0', port=5000)
