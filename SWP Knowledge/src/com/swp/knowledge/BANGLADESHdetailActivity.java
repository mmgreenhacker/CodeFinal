package com.swp.knowledge;

import java.util.ArrayList;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.Window;
import android.view.WindowManager;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.Toast;
import android.support.v4.app.NavUtils;

public class BANGLADESHdetailActivity extends Activity {
	public int iTyped = 0;
	public int iPos = 0;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		 requestWindowFeature(Window.FEATURE_NO_TITLE);
			this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
					WindowManager.LayoutParams.FLAG_FULLSCREEN);
		Intent intent = getIntent();
		iTyped = intent.getIntExtra(BANGLADESHlistActivity.EXTRA_MESSAGE_BANGLADESH_TYPE, 0);
		iPos = intent
				.getIntExtra(BANGLADESHlistActivity.EXTRA_MESSAGE_BANGLADESH_POSITION, 0);

		setContentView(R.layout.activity_bangladeshdetail);
		// Toast.makeText(getApplicationContext(),
		// String.valueOf(iTyped),Toast.LENGTH_SHORT).show();
		String img = "";
		switch (iTyped) {
		// radar
		case 1:
			img = "bangladeshr" + String.valueOf(iPos + 1);			
			break;
		// guns
		case 2:
			img = "bangladeshg" + String.valueOf(iPos + 1);			
			break;
		// missile
		case 3:
			img = "bangladeshm" + String.valueOf(iPos + 1);			
			break;

		}
		//Toast.makeText(getApplicationContext(), img,Toast.LENGTH_SHORT).show();
		ImageView imageview = (ImageView)findViewById(R.id.imageBANGLADESHdetail);
		int id = getResources().getIdentifier("com.swp.knowledge:drawable/" + img, null, null);
        imageview.setImageResource(id);
	}
}
