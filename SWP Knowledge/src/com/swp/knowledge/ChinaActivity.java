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

public class ChinaActivity extends Activity {

    public static final String EXTRA_MESSAGE_CHINA = "com.engineer4myanmar.swp.knowledge.CHINA";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_china);
   
    }
	//radar 1 guns 2 missile 3
	public void funCHINAradars1(View v)
	{
		
	}
	  public void funCHINAradars(View v)
	    {
		  try{
			  Intent ChinaIntent = new Intent(ChinaActivity.this,
				CHINAlistActivity.class);
	    	ChinaIntent.putExtra(EXTRA_MESSAGE_CHINA, 1);
			startActivity(ChinaIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funCHINAguns(View v)
    {
    	Intent ChinaIntent = new Intent(ChinaActivity.this,
			CHINAlistActivity.class);
    	ChinaIntent.putExtra(EXTRA_MESSAGE_CHINA, 2);
		startActivity(ChinaIntent);
    }
  
    public void funCHINAmissiles(View v)
    {
    	Intent ChinaIntent = new Intent(ChinaActivity.this,
			CHINAlistActivity.class);
    	ChinaIntent.putExtra(EXTRA_MESSAGE_CHINA, 3);
		startActivity(ChinaIntent);
    }
    
}
