using UnityEngine;
using UnityEngine.UI;

namespace Home {
    public class AnalysisController : MonoBehaviour {
        private void Start() {
            if(GameManager.instance.triedQuestion == 0) {
                gameObject.GetComponent<Text>().text = "암산 연습 앱에 오신 것을 환영합니다!\n지금 바로 암산 연습을 시작해 보세요";
            } else {
                gameObject.GetComponent<Text>().text = $"총 {GameManager.instance.triedQuestion:##,###}문항을 시도하였으며\n그 중 {GameManager.instance.performance:F2}%가 정답입니다. ";
            }
        }
    }
}
