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

public class LaosActivity extends Activity {

    public static final String EXTRA_MESSAGE_LAOS = "com.engineer4myanmar.swp.knowledge.LAOS";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_laos);
   
    }
	//radar 1 guns 2 missile 3
	public void funLAOSradars1(View v)
	{
		
	}
	  public void funLAOSradars(View v)
	    {
		  try{
			  Intent LaosIntent = new Intent(LaosActivity.this,
				LAOSlistActivity.class);
	    	LaosIntent.putExtra(EXTRA_MESSAGE_LAOS, 1);
			startActivity(LaosIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funLAOSguns(View v)
    {
    	Intent LaosIntent = new Intent(LaosActivity.this,
			LAOSlistActivity.class);
    	LaosIntent.putExtra(EXTRA_MESSAGE_LAOS, 2);
		startActivity(LaosIntent);
    }
  
    public void funLAOSmissiles(View v)
    {
    	Intent LaosIntent = new Intent(LaosActivity.this,
			LAOSlistActivity.class);
    	LaosIntent.putExtra(EXTRA_MESSAGE_LAOS, 3);
		startActivity(LaosIntent);
    }
    
}
