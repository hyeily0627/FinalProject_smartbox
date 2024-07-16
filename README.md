# FinalProject_smartbox
파이널 프로젝트 스마트무인택배함 개인 업로드 리포지토리

# 기본 UI 제작 
## 사용 툴 : Figma
- 전체기간 : 2024-05-27 ~ 2024-06-03

![피그마](https://raw.githubusercontent.com/hyeily0627/FinalProject_smartbox/main/images/003.png) 

# WPF로 작업
## 사용 툴 : Visual code - WPF애플리케이션
- 전체기간 : 2024-06-04 ~ 2024-07-03
  - 전체 구현 진행했으나, WPF로는 안드로이드 구현이 불가하여 중단함 

# Maui로 앱개발 
## 사용 툴 : Visual code - .Net Maui앱 
- 전체기간 : 2024-07-04 ~ 진행중
- 2024-07-04 : maui 세팅 및 기본 xaml 사용법 숙지
- 2024-07-05
  - 앱 첫화면 구현 (MainPage.xaml) [mainpage](https://raw.githubusercontent.com/hyeily0627/FinalProject_smartbox/main/images/001.png) 
    - 번호창 유효성 검사 설정 [mainpageError](https://raw.githubusercontent.com/hyeily0627/FinalProject_smartbox/main/images/002.png) 
    - 입력버튼 클릭시 다음 메뉴창으로 전환
  - 메뉴창 구현(MenuPage.xaml)
  - 코드번호 확인창 구현(CodeNumberPage.xaml)
- 2024-07-08
  - 택배함 위치 확인창 구현(MapPage.xaml)
  - 내정보 페이지 구현(MyInfoPage.xaml)
  - 설정 페이지 구현(SettingsPage.xaml)
  - 클릭이벤트 연결 확인
  - 🚨 택배함 영상 확인창은 CAM 및 DB 연결 좀 더 연구 후 제작
- 2024-07-09
  - MapPage 구글 지도 구현 및 택배함 위치 지정으로 라디오박스 클릭시 해당 지도로 줌인
- 2024-07-15
  - 폰에서 구동 확인
