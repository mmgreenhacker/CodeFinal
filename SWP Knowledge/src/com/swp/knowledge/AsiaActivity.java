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

public class AsiaActivity extends Activity {

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_asia);
        
    }

    public void funChina(View v) {
		startActivity(new Intent(AsiaActivity.this, ChinaActivity.class));
		//MainActivity.this.finish();
	}
	public void funIndia(View v) {
		startActivity(new Intent(AsiaActivity.this, IndiaActivity.class));
		//MainActivity.this.finish();
	}
	public void funThailand(View v) {
		startActivity(new Intent(AsiaActivity.this, ThailandActivity.class));
		//MainActivity.this.finish();
	}
	public void funLaos(View v) {
		startActivity(new Intent(AsiaActivity.this, LaosActivity.class));
		//MainActivity.this.finish();
	}
	public void funBangladesh(View v) {
		startActivity(new Intent(AsiaActivity.this, BangladeshActivity.class));
		//MainActivity.this.finish();
	}


}
