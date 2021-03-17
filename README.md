# AR디펜스게임 개발
Individual project for SoftwareDesign <br />
- email address : jw_29@naver.com.com <br />
- Demo Video : https://www.youtube.com/watch?v=02WQKm4_kv0&t=12s <br />

## Introduction
단국대학교 퇴계기념중앙도서관 내에서 책의 위치를 AR로 찾아주는 App입니다. 도서관 내의 배치도와 청구기호로만 책을 찾아야한다는 불편함을 AR로 해결해보았습니다.
1. 열람실의

## Development Environment
- mysql @8.0.18
- Apache2 Server
- php
- Android Studio @3.5.3

## Application Version
- minSdkVersion : 15
- targetSdkVersion : 26

## APIs
- open API of Korean Film Council (homepage : https://www.kobis.or.kr/kobisopenapi/homepg/main/main.do) <br />
If you want to get box office ranking, sign up to this homepage and get own key. <br />
- open API of NAVER (homepage : https://developers.naver.com/main/) <br />
If you want to get Movie Poster, sign up to this homepage and get own key. <br />
- google map <br />
If you want to get locations of theaters, sign up to google cloud platform and get own key.

## Database table information
database table backup file is in /server/backup.sql <br />
mysql -u [account] -p [database] < backup.sql

## screenshot
<img src="/images/Screenshot_1.png" width="180px" height="320px" title="Login" alt="Login"></img>
<img src="/images/Screenshot_2.png" width="180px" height="320px" title="SignUp" alt="SignUp"></img>
<img src="/images/Screenshot_3.png" width="180px" height="320px" title="CommertialMovie" alt="CommertialMovie"></img>
<img src="/images/Screenshot_4.png" width="180px" height="320px" title="IndependentMovie" alt="IndependentMovie"></img>
<img src="/images/Screenshot_5.png" width="180px" height="320px" title="Theater" alt="Theater"></img>
<img src="/images/Screenshot_6.png" width="180px" height="320px" title="Review" alt="Review"></img>
<img src="/images/Screenshot_7.png" width="180px" height="320px" title="myReview" alt="myReview"></img>

## Final Presentation PPT
<img src="/images/finalPT_1.png" width="360px" height="270px" title="finalPPT" alt="finalPPT"></img>
<img src="/images/finalPT_2.png" width="360px" height="270px" title="finalPPT" alt="finalPPT"></img>
<img src="/images/finalPT_3.png" width="360px" height="270px" title="finalPPT" alt="finalPPT"></img>
<img src="/images/finalPT_4.png" width="360px" height="270px" title="finalPPT" alt="finalPPT"></img>
<img src="/images/finalPT_5.png" width="360px" height="270px" title="finalPPT" alt="finalPPT"></img>

## License
MoveItMovie is released under the MIT License. http://www.opensource.org/licenses/mit-license
