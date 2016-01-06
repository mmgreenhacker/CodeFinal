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

public class USAActivity extends Activity {

    public static final String EXTRA_MESSAGE_USA = "com.engineer4myanmar.swp.knowledge.USA";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_usa);
   
    }
	//radar 1 guns 2 missile 3
	public void funUSAradars1(View v)
	{
		
	}
	  public void funUSAradars(View v)
	    {
		  try{
			  Intent UsaIntent = new Intent(USAActivity.this,
				USAlistActivity.class);
	    	UsaIntent.putExtra(EXTRA_MESSAGE_USA, 1);
			startActivity(UsaIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funUSAguns(View v)
    {
    	Intent UsaIntent = new Intent(USAActivity.this,
			USAlistActivity.class);
    	UsaIntent.putExtra(EXTRA_MESSAGE_USA, 2);
		startActivity(UsaIntent);
    }
  
    public void funUSAmissiles(View v)
    {
    	Intent UsaIntent = new Intent(USAActivity.this,
			USAlistActivity.class);
    	UsaIntent.putExtra(EXTRA_MESSAGE_USA, 3);
		startActivity(UsaIntent);
    }
    
}
