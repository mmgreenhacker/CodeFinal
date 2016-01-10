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

public class IndiaActivity extends Activity {

    public static final String EXTRA_MESSAGE_INDIA = "com.engineer4myanmar.swp.knowledge.INDIA";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_india);
   
    }
	//radar 1 guns 2 missile 3
	public void funINDIAradars1(View v)
	{
		
	}
	  public void funINDIAradars(View v)
	    {
		  try{
			  Intent IndiaIntent = new Intent(IndiaActivity.this,
				INDIAlistActivity.class);
	    	IndiaIntent.putExtra(EXTRA_MESSAGE_INDIA, 1);
			startActivity(IndiaIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funINDIAguns(View v)
    {
    	Intent IndiaIntent = new Intent(IndiaActivity.this,
			INDIAlistActivity.class);
    	IndiaIntent.putExtra(EXTRA_MESSAGE_INDIA, 2);
		startActivity(IndiaIntent);
    }
  
    public void funINDIAmissiles(View v)
    {
    	Intent IndiaIntent = new Intent(IndiaActivity.this,
			INDIAlistActivity.class);
    	IndiaIntent.putExtra(EXTRA_MESSAGE_INDIA, 3);
		startActivity(IndiaIntent);
    }
    
}
