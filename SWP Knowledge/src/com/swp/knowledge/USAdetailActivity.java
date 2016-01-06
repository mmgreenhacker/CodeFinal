package com.swp.knowledge;

import java.util.ArrayList;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.Toast;
import android.support.v4.app.NavUtils;

public class USAdetailActivity extends Activity {
	public int iTyped = 0;
	public int iPos = 0;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		Intent intent = getIntent();
		iTyped = intent.getIntExtra(USAlistActivity.EXTRA_MESSAGE_USA_TYPE, 0);
		iPos = intent
				.getIntExtra(USAlistActivity.EXTRA_MESSAGE_USA_POSITION, 0);

		setContentView(R.layout.activity_usadetail);
		// Toast.makeText(getApplicationContext(),
		// String.valueOf(iTyped),Toast.LENGTH_SHORT).show();
		String img = "";
		switch (iTyped) {
		// radar
		case 1:
			img = "usar" + String.valueOf(iPos + 1);			
			break;
		// guns
		case 2:
			img = "usag" + String.valueOf(iPos + 1);			
			break;
		// missile
		case 3:
			img = "usam" + String.valueOf(iPos + 1);			
			break;

		}
		//Toast.makeText(getApplicationContext(), img,Toast.LENGTH_SHORT).show();
		ImageView imageview = (ImageView)findViewById(R.id.imageUSAdetail);
		int id = getResources().getIdentifier("com.swp.knowledge:drawable/" + img, null, null);
        imageview.setImageResource(id);
	}
}
