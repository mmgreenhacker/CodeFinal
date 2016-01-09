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

public class RUActivity extends Activity {

    public static final String EXTRA_MESSAGE_RU = "com.engineer4myanmar.swp.knowledge.RU";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_ru);
   
    }
	//radar 1 guns 2 missile 3
	public void funRUradars1(View v)
	{
		
	}
	  public void funRUradars(View v)
	    {
		  try{
			  Intent UsaIntent = new Intent(RUActivity.this,
				RUlistActivity.class);
	    	UsaIntent.putExtra(EXTRA_MESSAGE_RU, 1);
			startActivity(UsaIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funRUguns(View v)
    {
    	Intent UsaIntent = new Intent(RUActivity.this,
			RUlistActivity.class);
    	UsaIntent.putExtra(EXTRA_MESSAGE_RU, 2);
		startActivity(UsaIntent);
    }
  
    public void funRUmissiles(View v)
    {
    	Intent UsaIntent = new Intent(RUActivity.this,
			RUlistActivity.class);
    	UsaIntent.putExtra(EXTRA_MESSAGE_RU, 3);
		startActivity(UsaIntent);
    }
    
}
