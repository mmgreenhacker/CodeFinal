package com.swp.knowledge;


import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.Window;
import android.view.WindowManager;
import android.widget.ImageView;
import android.support.v4.app.NavUtils;

public class AirDetialActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Intent intent = getIntent();
        int iPosition = intent.getIntExtra(AirActivity.EXTRA_MESSAGE_AIR, 0);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_air_detial);
        ImageView imageview = (ImageView)findViewById(R.id.imageview);
        String image="";
        switch(iPosition+1)
        {
        case 1: image="s1";break;
        case 2: image="s2";break;
        case 3: image="s3";break;
        case 4: image="s4";break;
        case 5: image="s5";break;
        case 6: image="s6";break;
        case 7: image="s7";break;
        case 8: image="s8";break;
        case 9: image="s9";break;
        case 10: image="s10";break;
        case 11: image="s11";break;
        case 12: image="s12";break;
        case 13: image="s13";break;
        case 14: image="s14";break;
        case 15: image="s15";break;
        case 16: image="s16";break;
        case 17: image="s17";break;
        case 18: image="s18";break;
        case 19: image="s19";break;
        case 20: image="s20";break;
        case 21: image="s21";break;
        case 22: image="s22";break;
        case 23: image="s23";break;
        }
        int id = getResources().getIdentifier("com.swp.knowledge:drawable/" + image, null, null);
        imageview.setImageResource(id);
    }



    


}






