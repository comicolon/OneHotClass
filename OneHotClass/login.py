import email
import imaplib
import pandas as pd
import time
from datetime import datetime
import os, sys
import configparser
# from bs4 import BeautifulSoup as bs
import quopri
import webbrowser

################################# 변수 받는 부분
loginEmail = sys.argv[1]
password = sys.argv[2]
# loginEmail = 'dfdfdaf@naver.com'
# password = 'hfhjbnf'
# second_pw = 'sdsdsdfdga'


if 'naver' in loginEmail:
    ID = loginEmail.split('@')[0]
    PW = password
elif 'gmail' in loginEmail:
    ID = loginEmail
    PW = password
###############################################

def __init__(self):
    super().__init__()

    self.session = None

# def config_setting(self):
#     self.config = configparser.ConfigParser()
#     self.config.read('config.ini')

def connectSession(self, URL):
    # gmail imap 세션 생성
    self.session = imaplib.IMAP4_SSL(URL)

    id = ID

    pw = PW

    # 로그인
    self.session.login(id, pw)


def searchEmail(self, inbox, attr):

    # 편지함 이름을 선택
    self.session.select(inbox)

    # 편지함 검색
    result, data = self.session.search(None, attr)

    return result, data

def disconnectSession(self):
    self.session.close()
    self.session.logout()

# 문자열의 인코딩 정보 추출 후, 문자열, 인코딩 얻기
def find_encoding_info(txt):
    info = email.header.decode_header(txt)
    s, encoding = info[0]
    return s, encoding

#메일 안의 날짜와 시간을 변환해주는 함수
def convert_date(txt):
    #string형식 날짜 Timestamp 형식으로 변경 후 문자열로 변경
    date = str(pd.Timestamp(txt))
    #년, 월, 일 분리
    day = date.split(' ')[0]
    #시, 분, 초 분리
    hour = date.split(' ')[1]
    #+00:00(시차표시) 분리
    hour = hour.split('+')[0]

    #list와 변수 생성
    list_for_date = []
    temp = 0
    #년, 월, 일을 정수로 변경하여 리스트에 삽입
    for day_split in day.split('-'):
        temp = int(day_split)
        list_for_date.append(temp)
    #시, 분, 초를 정수로 변경하여 리스트에 삽입
    for hour_split in hour.split(':'):
        temp = int(hour_split)
        list_for_date.append(temp)
    #datetime 형식으로 변경을 위해서는 정수형으로 datetime 함수 사용(UTC+9시간을 위해 시간에 9를 넣음)
    date = datetime(list_for_date[0], list_for_date[1], list_for_date[2], list_for_date[3]+9, list_for_date[4],
                    list_for_date[5])

    #시간 차 계산(split을 위해 str변환)
    diff = str(datetime.now() - date).split(':')[1]
    #분의 자리에서 3보다 같거나 크면 0반환, 아니면 1반환(대소비교를 위해 int변환)
    if int(diff) >=3:
        return 0
    else:
        return 1

class Main():
    def __init__(self):

        # 접속 메일 서버
        if 'naver' in loginEmail:
            connectSession(self, 'imap.naver.com')
        elif 'gmail' in loginEmail:
            connectSession(self, 'imap.gmail.com')

        # connectSession(self, 'imap.gmail.com', loginEmail.split, password)

        # 읽지 않은 메일 정보 가져오기
        typ, [msg_ids] = searchEmail(self, 'Inbox', 'UNSEEN')

        # 읽지 않은 메일 전부
        num = msg_ids.split()
        # 메일을 최신 메일부터 읽기
        for n in reversed(num):
            # 메일 정보를 통해 메일 읽기
            result, data = self.session.fetch(n, '(RFC822)')

            # 메일의 기본 정보 출력하기 (사람이 읽기 힘듦)
            raw_email = data[0][1]

            #메시지 처리(email 모듈 활용)
            email_message = email.message_from_bytes(raw_email)

            #한글 깨지는 문제
            sender, encoder = find_encoding_info(email_message['From'])
            subject, encode = find_encoding_info(email_message['Subject'])

            #이메일 받은 시간
            Email_recieve_date = email_message['Date']

            #encode가 None타입의 경우
            if encode == None :
                continue

            # 제목 맞지않으면 다음 이메일
            if str(subject, encode) != "[코드스테이츠] 본인 인증 진행 안내":
                continue
            else:
                # 메일이 가기까지 시간 5초 기다림
                time.sleep(5)

                # 3분 이내의 메일이 없을 경우 종료
                if convert_date(email_message['Date']) == 0:
                    print('3분 이내의 메일이 없습니다.')
                    break

                #본문 내용 확인
                if email_message.is_multipart():
                    for part in email_message.get_payload():
                        if part.get_content_type() == 'text/plain':
                            bytes = part.get_payload(decode=True)
                            print(bytes)

                #종료
                break;

        # 접속 종료
        disconnectSession(self)

if __name__ == "__main__":
    Main()