package com.swp.knowledge;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.support.v4.app.NavUtils;

public class SupercActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_superc);
       
    }
    public void funUSA(View v) {
		startActivity(new Intent(SupercActivity.this, USAActivity.class));
		//MainActivity.this.finish();
	}
	public void funRU(View v) {
		startActivity(new Intent(SupercActivity.this, RUActivity.class));
		//MainActivity.this.finish();
	}
	public void funIran(View v) {
		startActivity(new Intent(SupercActivity.this, IranActivity.class));
		//MainActivity.this.finish();
	}
	public void funIsrael(View v) {
		startActivity(new Intent(SupercActivity.this, IsraelActivity.class));
		//MainActivity.this.finish();
	}
   
}
