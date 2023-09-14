# ReadMe

### 목차

1. 게임 설명 및 개발 기간
2. 구현 목록 및 담당자
3. 플레이 영상
4. 게임 화면 설명
5. 클래스 설명
6. 개발 후기

---

# 1. 게임 설명 및 개발 기간

## 1️⃣ 게임 설명

- **게임명: `JellyStruggle`**
- **설명:** [내일 배움 캠프 8기 Unity] Chapter 3-2 게임개발 입문 팀 프로젝트
- **장르**: 슈팅 조류 피하기(Dodge) 게임
- **개요:**
    - 젤리 왕국에 나타난 새들을 피하고 물리치며 돈을 벌어 새로운 젤리 동료를 구하는 닷지 게임!
- **조작법:**
    - **상하좌우 이동:** W, A, S, D
        - 코인에 닿으면 코인을 먹고 점수를 획득한다.
        - 적에게 닿으면 적의 데미지 만큼 젤리의 체력이 닳는다.
    - **총 쏘기**: 마우스
        - 현재 마우스 방향으로 젤리의 공격 속도만큼 총알이 나가고, 이 총알에 닿은 새는 죽는다.
    - **젤리는 귀엽지만 무자비하다.**
- **사용한 에셋**
    - **[골드메탈 - 볼트 2D 젤리팜 에셋 팩](https://assetstore.unity.com/packages/2d/characters/bolt-2d-jellyfarm-assets-pack-188722)**
    - **[2D Cartoon Birds pack](https://assetstore.unity.com/packages/2d/characters/2d-cartoon-birds-pack-149167)**
    - **[2D Character Sprite Animation - Penguin](https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747)**
    - **[상어](https://opengameart.org/content/seadefender-assets)**

## 2️⃣ 개발 기간 `2023.09.08 ~ 2023.09.14`

- **`2023.09.08 (금)`**
    - 📝 S.A 작성
    - 📝 필수 및 선택 요구 사항 우선 순위 설정
    - 👥 역할 분담 및 기능 명세서 작성
- **`2023.09.11 (월)`**
    - 🧑‍💻 구현
    - 📒 구현을 위한 열공
- **`2023.09.12 (화)`**
    - 🧑‍💻 구현
- **`2023.09.13 (수)`**
    - 🧑‍💻 구현한 내용 통합
    - 🐞 버그 찾고 수정
- **`2023.09.14 (목)`**
    - 📝 ReadMe파일 작성
    - 📝 제출 및 발표

---

# 2. 구현 목록 및 담당자

## 1️⃣ 구현 목록

아래의 필수 요구 사항 및 선택 요구사항은 모두 구현 완료한 상태이다.

🔽 **필수 요구 사항 목록**

- 게임 화면
- 캐릭터
- 총알과 공격
- 충돌 감지
- 게임 로직

🔽 **선택 요구사항 목록**

**[ 게임 난이도 조절 ]**

1. 게임 스테이지 구현 (난이도 - ★★★★☆)

**[ 아이템 시스템 ]**

1. 코인 연속 획득시 추가 보상 (난이도 - ★★★★☆)

**[ 특수 능력 ]**

1. 다각도 에임  (난이도 - ★★★★☆)

**[ 시청각적 효과 ]**

1. 시각적 효과 - 젤리의 동시다발적인 공격 
(난이도 - ★★★☆☆)
2. ~~사운드 효과 - 젤리의 흥을 돋궈 줄 음향 효과(난이도 - ★☆☆☆☆)~~

## 2️⃣ 담당자

![Untitled](ReadMe%2018f2f49d00904fe0b49963d604d35ae1/Untitled.png)

---

# 3. 플레이 영상

[🔗 **영상 보러가기**](https://www.youtube.com/watch?v=cNl5ciNcWFQ)

---

# 4. 게임 방법

## 0️⃣ 캐릭터 이름 설정 및 변경 화면

**🔽 캐릭터 이름 설정**

캐릭터 이름을 입력할 수 있다.

캐릭터 이미지를 누르면 캐릭터를 변경할 수 있다.

![Untitled1](ReadMe%2018f2f49d00904fe0b49963d604d35ae1/Untitled1.png)

**🔽 캐릭터 변경 화면**

귀여운 젤리를 고를 수 있다. 먹을 순 없다.

각 젤리마다 장단점이 있다. 체력이 높은 젤리, 이동 속도가 빠른 젤리 등

![Untitled2](ReadMe%2018f2f49d00904fe0b49963d604d35ae1/Untitled2.png)

## 1️⃣ 로비 화면

**🔽 로비화면**

- **로비화면에서 보이는 정보**
    - 레벨: 현재 플레이어가 해금한 최대 스테이지 번호
    - 유저명, 캐릭터 이미지
    - 획득한 코인
- **캐릭터 설정**
    - 캐릭터 이름 설정 및 변경하는 화면으로 이
- **게임시작**
    - 스테이지 선택 화면으로 이동
- **게임종료**
    - 앱에서 탈주

![Untitled3](ReadMe%2018f2f49d00904fe0b49963d604d35ae1/Untitled3.png)

     

# 2️⃣ 게임 화면

**🔽 스테이지 선택**

해금한 스테이지는 스테이지 번호와 해당 스테이지에서의 최고 점수를 확인할 수 있다.

잠긴 스테이지는 클릭할 수 없고, 자물쇠로 표시된다.

현재 스테이지는 총 3단계로 구성되어 있다.

![Untitled4](ReadMe%2018f2f49d00904fe0b49963d604d35ae1/Untitled4.png)

**🔽 게임 화면**

젤리는 유연한 무빙과 다발적인 공격력을 선보인다.

악독한 조류들은 코인과 함께 하늘에서 떨어진다.

난이도가 올라 갈 수록 적의 속도와 개체 수가 증가하여 스릴이 넘치니 마구마구 때려 잡아야 한다.

![Untitled5](ReadMe%2018f2f49d00904fe0b49963d604d35ae1/Untitled5.png)

## 3️⃣ 게임 종료 화면

**🔽 결과 화면**

플레이 중 얻은 점수를 보여주며, 이는 플레이어가 획득한 코인과 동일하다.

해당 스테이지의 클리어 조건 점수 달성 시 다음 스테이지로 이동 혹은 로비로 이동할 수 있다.

해당 스테이지의 클리어 조건 점수 미달성 시 해당 스테이지 재진행 혹은 로비로 이동할 수 있다.

![Untitled6](ReadMe%2018f2f49d00904fe0b49963d604d35ae1/Untitled6.png)

---

# 5. 클래스 설명

- **UI 자동화**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | ResourceManager | 리소스들을 읽고 생성하거나 삭제하는 함수 정의 |
    | UIManager | 씬에 UI를 보여주게 한다 |
    | UI_EventHandler | UI에 추가할 수 있는 이벤트 함수들 정의 |
    | BaseScene | 씬 정보 정의 및 해당 씬의 UI 동적 생성 |
    | UI_Base | enum으로 정의된 UI 오브젝트를 연결하고 가져올 수 있게 해준다. |
    | UI_Popup | 팝업 UI 정의 및 관리 |
    | UI_Scene | 씬 UI 정의 및 관리 |
- **공통 (Util)**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | Managers | 모든 매니저들을 싱글톤으로 관리 |
    | GameManager | 게임에서 필요한 스테이지, 캐릭터 정보들, 타이머 시작 여부 등을 관리 |
    | JsonReader | json파일 읽어오는 기능 |
    | Utils | 공통적으로 필요한 기능 |
    | Define | 공통적으로 사용되는 것들을 enum으로 정의 |
    | Extension | 유니티 게임오브젝트의 기능 확장 |
- **JsonData**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | CharacterInfo | characterData.json을 객체로 만들기 위해 정의된 캐릭터 정보 |
    | characterData.json | 캐릭터들의 이미지, 능력치 정의 |
    | Stage | stageData.json을 객체로 만들기 위해 정의된 스테이지 정보 |
    | stageData.json | 스테이지 번호, 해금 여부, 클리어 조건, 난이도 등 정의 |

- **캐릭터 이름 설정 및 변경 화면**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | UI_SettingCharacter | UI 및 캐릭터 이름 설정(2 ~ 10, 한글/영어/숫자만 가능하게) |
    | UI_SettingCharacterImage | UI 및 캐릭터 설정 |
    | UserManager | 게임에서 유저의 스코어 등 여러 정보 저장 |
    | GameManager | json 파일로 된 characterinfo, stage 정보 받아와서 저장 |
    | CharacterInfo.json | 케릭터들의 정보를 가지고 있는 json 파일. |
- **로비 화면**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | LobbyScene | 게임의 시작 화면 |
    | UI_Lobby | 로비화면의 UI 관리 |
    | GameManager | 유저의 캐릭터 정보 |
    | UserManager | 유저의 기존 정보 (이름, 코인, 해금한 스테이지 정보 등) |
- **스테이지 선택 화면**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | SelectStageScene | 난이도 선택 화면 |
    | UI_SelectStage | 해금한 난이도, 미해금 난이도 별 UI 관리 |
    | GameManager | StageInfo.json 정보를 리스트로 관리 |
    | StageInfo.json | 스테이지 별 정보 (클리어 점수, 적과 코인 속도 및 생성 개수 등) |
- **게임 화면**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | Projectile | 임의로 떨어지는 Coin과 enemy 클래스의 부모 클래스 |
    | Coin | GameManager로부터 Stage 정보를 받아와, 속도, 크기, 소환 수 등을 설정한다. |
    | CoinController | Coin의 정보에 맞게 Coin을 인스턴스화 |
    | Enemy | GameManager로부터 Stage 정보를 받아와, 속도, 크기, 소환 수 등을 설정한다.|
    ||Player 혹은 Bullet과 충돌하면, 각각 Player Hp를 감소시키고 사라진다. |
    | EnemyController | Enemy의 정보에 맞게 Enemy를 인스턴스화|
    ||[Serializable] 에 스테이지별 Enemy의 sprite와 animator을 가진 프리팹을 부착하여, Stage 별로 Enemy를 구분하여 랜덤하게 소환한다. |
    | ObjectPoolManager | Enemy에 대한 오브젝트 풀을 관리한다. |
    | StartTimer | 최초의 Enemy 혹은, Coin이 떨어지는 순간 게임을 시작시킨다. |
    | Player | Player 정보를 UserManager로부터 받아와 Sprite, Hp등의 정보를 게임화면에 적용한다. |
    | Bullet | Player가 마우스 방향으로 쏘는 투사체를 인스턴스화|
    ||[Serializable] 에 각 종류별 Bullet의 sprite와 animator을 가진 프리팹을 부착하여, Style에 따라 다양한 모양의 Bullet을 적용시킨다. |
- **결과 화면**
    
    
    | 클래스 | 기능 |
    | --- | --- |
    | ResultScene | 캐릭터 선택 및 생성 화면 |
    | UI_Result | 클리어 조건에 따른 결과 화면 UI 설정 |
    | UserManager | 유저의 게임 결과 저장 |

---

# 6. 후기

| 팀원명 | 어려웠던 점 | 해결 방안 |
| --- | --- | --- |
| 윤지연 | 1. 이름 입력 예외처리| 1. Regex.Replace도 안되고, foreach로 하면 마지막에 공백값이 있는데 그 공백값이 “\0”, “ “, “\n, “\r” 중 어떤 것도 아니여서 for문과 SubString으로 해결. 특수문자는 손수 미리 입력해줘서 해결.|
||2. 클래스 설계 | 2. 서로 호출해야 하는 부분, 인덱싱 하는 값 등 여러 사항들을 계속 팀원과 얘기하면서 진행 |
| 고영현 | 1. 이름 입력 예외처리|1. textinput에서 string 값을 받아와 예외처리를 하는 것이였는데 마지막 글자에 이상한 공백문자가 나타나서 예외처리하기 정말 어려웠습니다. 그래서 특수 문자를 모두 적고 Contain으로 검사했습니다.|
||2. 디버깅 | 2. 위에 것을 해결하는 도중 디버깅을 하였는데 어려웠습니다. |
| 어하림 | 1. 깃허브 푸쉬오류 | 1. 깃허브 푸시가 안되고, 오류가 떠서 팀원분들의 도움으로 브랜치 다시 파서 올렸더니 되었습니다. |
| 지민규 | 1. 단계별로 적용할 Sprite 및 Animator 설정|1. 임시 프리팹을 만들고, 해당 투사체를 관리하는 오브젝트 inspector에 직렬화를 통해 유니티 상에서 단계별로 임시 프리팹을 가져와 적용함.|
||2. 디버깅|2. 디버깅을 Debug.Log 로 해결했었는데, 중단점을 걸고 Unity와의 연결을 통해 Unity 화면과 연동하여 디버깅을 함. |
||3. 인스턴스화한 객체에 설정한 정보 적용|3. Controller에 프리팹을 넣어두고, 프리팹에 연결된 스크립트에서 GameManager를 통해 정보를 가져오는 것을 기대했는데, 프리팹의 초기값만 가져와 제대로 적용이 안되었다. 그래서, Controller 에서 직접 GameManager를 통해 정보를 가져오게 함. (조금 더 이해가 필요해, 따로 복습할 예정)|
||4. 이벤트 함수와 유니티의 흐름 | 4. 다른 클래스를 참조할 때, Start() 혹은 Awake()에서 초기화를 해야함. (조금 더 이해가 필요해, 따로 복습할 예정) |
| 최하나 | 1. 결과보기 화면 :  UI를 만들때 UI 요소들의 위치나 만드는 방법에 대한 배경학습이 잘 되있지 않아서 요소의 위치 설정, 구성이 어려웠다.| 1. 해결 방법 : 지연님의 조언으로 시작화면의 UI를 보며 원하는 UI의 위치와 용도로 변경하며 결과화면 UI를 만들었다. |
||2. Unity의 각 오브젝트들의 관계에 대한 이해와 사용이 어려었다.|2. 해결 방법 : 전체적으로 지연님이 만들어주신 UI 자동화 설명서를 보며 결과화면 UI에 필요한 script, Scene, UI에 필요한 요소들을 만들었고, 만드는 과정에서 결과Scene의 컴포넌트를 추가할때 추가해야 할 스크립트를 잘 모르겠는 부분은 영현님이 필요한 script를 알려주셨고, 만든 Scene을 실행할 수 없었던 부분은 지연님이 build setting에서 추가해야 할 Scene을 알려주셔서 배우고 실행할 수 있었다. |
||3. GitHub 데스크톱 사용이 어려웠다.|3. 해결 방법 :  만드는 과정에서 결과Scene의 컴포넌트를 추가할 때 추가해야 할 스크립트를 잘 모르겠는 부분은 영현님이 필요한 script를 알려주셨고, 만든 Scene을 실행할 수 없었던 부분은 지연님이 build setting에서 추가해야 할 Scene을 알려주셔서 배우고 실행할 수 있었다. |
||4. GitHub 데스크톱 사용이 어려웠다.|4. 해결 방법 : 팀 프로젝트 리포지토리에 내가 작업하는 브런치를 안전하게 올릴 수 있도록 민규님이 Github 데스크톱에서 브런치 생성과 push 사용법을 알려주셨고, 추후 브런치를 잘못생성해서 commit한 부분에 대한 삭제 등 수습할 부분은 영현님이 도와주셔서 해결할 수 있었다.|
