package com.engineer4myanmar.intakebook;




import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.view.animation.Animation.AnimationListener;
import android.widget.EditText;
import android.widget.ImageView;

public class CadetIBookSplashActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_cadet_ibook_splash); 
        ImageView ivLogo = (ImageView) findViewById(R.id.ivLogo);
        Animation rotate = AnimationUtils.loadAnimation(this, R.anim.custom_anim);
        ivLogo.startAnimation(rotate);
        
       // rotate.setAnimationListener(new AnimationListener(){
        //	public void onAnimationEnd(Animation animation){        		
        //	startActivity(new Intent(CadetIBookSplashActivity.this,CadetIBookMainActivity.class));
        //	CadetIBookSplashActivity.this.finish();
        //	}

    	//	public void onAnimationRepeat(Animation animation) {
    	//		// TODO Auto-generated method stub
    			
    	//	}

    	//	public void onAnimationStart(Animation animation) {
    	//		// TODO Auto-generated method stub
    			
    	//	}
       // });
       
        
    }
    

    public void funStart(View v)
    {
    	startActivity(new Intent(CadetIBookSplashActivity.this,CadetIBookMainActivity.class));
    	CadetIBookSplashActivity.this.finish();
    }
    
    public void funLogin(View v)
    {
    	EditText etPassword = (EditText)findViewById(R.id.etPassword );
    	String sPass="";
    	sPass=etPassword.getText().toString();
    	if(sPass.equals("awh"))
    	{
    		startActivity(new Intent(CadetIBookSplashActivity.this,CadetIBookMainActivity.class));
    		CadetIBookSplashActivity.this.finish();
    	}
    	
    }
}
