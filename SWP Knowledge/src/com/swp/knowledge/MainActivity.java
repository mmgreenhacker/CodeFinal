package com.swp.knowledge;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.EditText;
import android.support.v4.app.NavUtils;

public class MainActivity extends Activity {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		setContentView(R.layout.activity_main);
	}

	public void funAir(View v) {
		startActivity(new Intent(MainActivity.this, AirActivity.class));
		//MainActivity.this.finish();
	}
	public void funSuperc(View v) {
		startActivity(new Intent(MainActivity.this, SupercActivity.class));
		//MainActivity.this.finish();
	}
	public void funAsia(View v) {
		startActivity(new Intent(MainActivity.this, AsiaActivity.class));
		//MainActivity.this.finish();
	}
}
