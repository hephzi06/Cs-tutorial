class Grading
{
  public string first_name , last_name,sub1, sub2, sub3, sub4, sub5;
  public int score1, score2, score3, score4, score5;


  public dynamic grades(int score){
    if (score > 100){
      return "Score should be less than 100";
    }else if (score >= 80) {
      return "A1";
    }else if (score <= 79) {
      return "B2";
    }else if (score <= 74) {
      return "B3";
    }else if (score <= 69) {
        return "C4";
    }else if (score <= 64) {
      return  "C5";
    }else if (score <= 59) {
      return "C6";
    }else if (score <= 49) {
      return "D7";
    }else if (score <= 44) {
    return  "E8";
    }else if (score > 0) {
      return "F9";
    }else{
      return "Invalid score";
    }
  }
}
