using System;
using System.Windows.Forms;
// 아래 구문은 필요 시 유지하되, 일반적으로 Form 컨트롤 사용 시 필수는 아닙니다.
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // [포커스 설정] 시작 시 텍스트박스에 커서 위치
            this.ActiveControl = txtTyppingbox;

            // [글자 수 제한] 최대 50자까지만 입력 가능하도록 설정
            txtTyppingbox.MaxLength = 50;
        }

        // [전송 버튼] 메시지 보내기
        private void btnSending_Click(object sender, EventArgs e)
        {
            // [공백 제거] Trim()을 사용하여 앞뒤 공백 제거
            string input = txtTyppingbox.Text.Trim();

            // [공백 제한] 내용이 비어있으면 전송하지 않음
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            // [시간 추가] 현재 시간을 "오전/오후 시:분" 형식으로 생성
            string currentTime = DateTime.Now.ToString("tt h:mm");

            // [문자열 결합] 입력 텍스트 + 시간
            string finalMsg = $"{input}  ({currentTime})";

            // [리스트 추가] 리스트박스에 한 번만 추가
            lstChatlist.Items.Add(finalMsg);

            // 타이틀 정보 업데이트
            UpdateTitle();

            // [마무리] 텍스트박스 비우기 및 다시 포커스
            txtTyppingbox.Clear();
            txtTyppingbox.Focus();
        }

        // [엔터 키 처리] 텍스트박스에서 엔터 입력 시 버튼 클릭 실행
        private void txtTyppingbox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                btnSending.PerformClick(); 
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lstChatlist.Items.Clear();
            UpdateTitle();
        }

        // [선택 삭제 버튼] 마우스로 선택한 특정 메시지만 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 리스트박스에서 무언가 선택되었는지 확인 (선택 안 됨 = -1)
            if (lstChatlist.SelectedIndex != -1)
            {
                // 선택된 위치(Index)의 항목을 삭제
                lstChatlist.Items.RemoveAt(lstChatlist.SelectedIndex);

                // 삭제 후 타이틀 개수 업데이트
                UpdateTitle();
            }
        }

        // [공통 기능] 타이틀에 메시지 개수 실시간 표기
        private void UpdateTitle()
        {
            this.Text = $"EchoMessenger - 메시지 개수: {lstChatlist.Items.Count}개";
        }
    }
}