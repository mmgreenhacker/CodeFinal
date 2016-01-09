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

public class IranActivity extends Activity {

    public static final String EXTRA_MESSAGE_IRAN = "com.engineer4myanmar.swp.knowledge.IRAN";
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_iran);
   
    }
	//radar 1 guns 2 missile 3
	public void funIRANradars1(View v)
	{
		
	}
	  public void funIRANradars(View v)
	    {
		  try{
			  Intent UsaIntent = new Intent(IranActivity.this,
				IRANlistActivity.class);
	    	UsaIntent.putExtra(EXTRA_MESSAGE_IRAN, 1);
			startActivity(UsaIntent);
		  }
		  catch(Exception ex)
		  {
			  Log.e("error",ex.toString());
		  }
	    	
	    }
	  
    public void funIRANguns(View v)
    {
    	Intent UsaIntent = new Intent(IranActivity.this,
			IRANlistActivity.class);
    	UsaIntent.putExtra(EXTRA_MESSAGE_IRAN, 2);
		startActivity(UsaIntent);
    }
  
    public void funIRANmissiles(View v)
    {
    	Intent UsaIntent = new Intent(IranActivity.this,
			IRANlistActivity.class);
    	UsaIntent.putExtra(EXTRA_MESSAGE_IRAN, 3);
		startActivity(UsaIntent);
    }
    
}
