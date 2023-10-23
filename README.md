# VR_BasketBall_Simulation
Unity와 Oculus Quest2를 이용하여 3D 가상 환경에서 농구를 체험할 수 있는 미니 게임  
  
VR 환경  
-  Oculus Quest2를 이용하기 위해 VR Integration 적용  
  
농구장 및 농구공 제작  
-  3D 오브젝트들을 이용하여 제작  
-  Texture를 입힌 Material을 오브젝트에 적용
  
농구공 탄성  
-  Physic Material을 적용하여 Bounciness 값을 조절  
  
골대 및 콜라이더 제작  
-  여러 오브젝트를 합쳐 골대를 직접 제작  
-  농구 골대에 충돌 처리를 위해 콜라이더 적용  
-  골 처리를 위한 그물 내 충돌 범위 설정  
  
점수판  
-  3D 오브젝트인 TextMeshPro를 이용하여 골대에 골을 넣으면 점수판의 점수가 오르는 스크립트 작성  
-  골대 안으로 들어오는 오브젝트가 'BasketBall'이라는 태그를 가지고 있어야 점수가 오름
-  점수가 오르면 공은 2초 후에 사라짐
-  사라진 공은 처음 공이 생성됐던 위치에 재생성
  
플레이어 기능  
-  OVR Plater Controller 컴포넌트의 Acceleration의 값을 조절하여 플레이어의 이동 속도 조절을 편리하게 조절  
-  OVR Grabber 스크립트에서 linear Velocity 값을 조절하여 오브젝트를 잡아 던지는 속도 변경  
  
충돌 개선  
-  컨트롤러와 오브젝트 콜라이더가 충돌해 플레이어가 밀려나는 현상 발생  
-  OVR Player Controller -> Custom Hand Left -> OVR Grabber 컴포넌트 -> Parent Transform에 Left Controller Anchor, Player에 OVR Player Controller 할당하여 밀려나는 현상 개선  

