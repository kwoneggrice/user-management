# UserManagement
- 회원 관리 시스템
- 등록된 회원의 성별, 강의 비율을 원형 차트로 확인할 수 있다.
- 회원 정보를 검색, 추가, 수정, 삭제할 수 있다.
- 관리자 로그인 기능
- 관리자 회원가입 시 관리자 코드 기입 후 회원가입 진행

# 사용한 패키지
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Pomelo.EntityFrameworkCore.MySql
- WinForms.DataVisualization

# 사용 기술
- Entity Framework Core
- Mysql
- Dependency Injection
- C#
- Winform

# DBContext로 테이블 생성
```
Add-Migration First // 마이그레이션 정보 생성
Update-Database // 정보를 가지고 실제 DB에 업데이트 수행
```

# 화면
### 관리자 로그인 화면
![스크린샷 2024-03-06 142957](https://github.com/kwoneggrice/user-management/assets/73627446/7d35bc58-87f3-4954-91da-c83db28028c0)

### 관리자 회원가입 화면
![스크린샷 2024-03-06 142614](https://github.com/kwoneggrice/user-management/assets/73627446/5cdfb35c-44fc-4c9c-b08e-5bafd9047940)

### 대시보드 화면
![스크린샷 2024-03-06 142630](https://github.com/kwoneggrice/user-management/assets/73627446/0887550e-83b6-4ff5-99e9-a058a12bc084)

### 유저 관리 화면
![스크린샷 2024-03-06 142635](https://github.com/kwoneggrice/user-management/assets/73627446/dfc7b386-fb80-4679-826e-a8947ed32a37)
