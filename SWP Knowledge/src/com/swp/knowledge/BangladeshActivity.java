package com.swp.knowledge;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.support.v4.app.NavUtils;

public class BangladeshActivity extends Activity {

    public static final String EXTRA_MESSAGE_BANGLADESH = "com.engineer4myanmar.swp.knowledge.BANGLADESH";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_bangladesh);
   
    }
	//radar 1 guns 2 missile 3
	public void funBANGLADESHradars1(View v)
	{
		
	}
	  public void funBANGLADESHradars(View v)
	    {
		  try{
			  Intent BangladeshIntent = new Intent(BangladeshActivity.this,
				BANGLADESHlistActivity.class);
	    	BangladeshIntent.putExtra(EXTRA_MESSAGE_BANGLADESH, 1);
			startActivity(BangladeshIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funBANGLADESHguns(View v)
    {
    	Intent BangladeshIntent = new Intent(BangladeshActivity.this,
			BANGLADESHlistActivity.class);
    	BangladeshIntent.putExtra(EXTRA_MESSAGE_BANGLADESH, 2);
		startActivity(BangladeshIntent);
    }
  
    public void funBANGLADESHmissiles(View v)
    {
    	Intent BangladeshIntent = new Intent(BangladeshActivity.this,
			BANGLADESHlistActivity.class);
    	BangladeshIntent.putExtra(EXTRA_MESSAGE_BANGLADESH, 3);
		startActivity(BangladeshIntent);
    }
    
}
