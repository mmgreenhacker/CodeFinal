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

public class ThailandActivity extends Activity {

    public static final String EXTRA_MESSAGE_THAILAND = "com.engineer4myanmar.swp.knowledge.THAILAND";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_thailand);
   
    }
	//radar 1 guns 2 missile 3
	public void funTHAILANDradars1(View v)
	{
		
	}
	  public void funTHAILANDradars(View v)
	    {
		  try{
			  Intent ThailandIntent = new Intent(ThailandActivity.this,
				THAILANDlistActivity.class);
	    	ThailandIntent.putExtra(EXTRA_MESSAGE_THAILAND, 1);
			startActivity(ThailandIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funTHAILANDguns(View v)
    {
    	Intent ThailandIntent = new Intent(ThailandActivity.this,
			THAILANDlistActivity.class);
    	ThailandIntent.putExtra(EXTRA_MESSAGE_THAILAND, 2);
		startActivity(ThailandIntent);
    }
  
    public void funTHAILANDmissiles(View v)
    {
    	Intent ThailandIntent = new Intent(ThailandActivity.this,
			THAILANDlistActivity.class);
    	ThailandIntent.putExtra(EXTRA_MESSAGE_THAILAND, 3);
		startActivity(ThailandIntent);
    }
    
}
