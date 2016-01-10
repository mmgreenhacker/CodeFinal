package com.swp.knowledge;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import android.os.Bundle;
import android.annotation.TargetApi;
import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;
import android.support.v4.app.NavUtils;

public class RUlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_RU_POSITION= "com.engineer4myanmar.swp.knowledge.RU.POSITION";
	public final static String EXTRA_MESSAGE_RU_TYPE = "com.engineer4myanmar.swp.knowledge.RU.TYPE";
	
	int iType=0;
	String[] ruGUNS = new String[] { 
			"Z5U-37", // 1
			"ZU-23-2", // 2
			"ZU-57-2(Ob'yekt 500)", // 3
			"AZP S-60", // 4
			"ZSU-23-4", // 5
			"37 mm AA M1939(61-K)", // 6
			
	};
	String[] ruMissiles = new String[] { 
			//rum
			"50R6 (S-350E) Vityaz", // 1
			"Tor Missile System", // 2
			"S-500 Missile System", // 3
			"S-400 Missile System (TRIUMF)", // 4
			"S-300 Family", // 5
			"S-300 Family အေထြေထြ အခ်က္အလက္မ်ား", // 6
			"S-200 Dubna", // 7
			"S-125 Neva/Pechora", // 8
			
	};
	String[] ruRadars = new String[] { "R1", // 1
			"R2", // 2
			"R3", // 3
			"R4", // 4
			"R5" // 5
	};

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);		
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		Intent intent = getIntent();
		iType = intent.getIntExtra(RUActivity.EXTRA_MESSAGE_RU, 0);
		Log.d("itype",String.valueOf(iType));
		setContentView(R.layout.activity_rulist);
		//Toast.makeText(getApplicationContext(), "OK",Toast.LENGTH_SHORT).show();
		
		final ListView listview = (ListView) findViewById(R.id.listviewRU);
		final ArrayList<String> list = new ArrayList<String>();
		switch (iType) {
		case 1:
			for (int i = 0; i < ruRadars.length; ++i) {
				list.add(ruRadars[i]);
			}
			break;
		case 2:
			for (int i = 0; i < ruGUNS.length; ++i) {
				list.add(ruGUNS[i]);
			}
			break;
		case 3:
			for (int i = 0; i < ruMissiles.length; ++i) {
				list.add(ruMissiles[i]);
			}
			break;
		}

	
		final StableArrayAdapter adapter = new StableArrayAdapter(this,
				android.R.layout.simple_list_item_1, list);
		listview.setAdapter(adapter);

		listview.setOnItemClickListener(new AdapterView.OnItemClickListener() {

			@TargetApi(16)
			public void onItemClick(AdapterView<?> parent, final View view,
					int position, long id) {
				final String item = (String) parent.getItemAtPosition(position);
				Toast.makeText(getApplicationContext(), item,
						Toast.LENGTH_SHORT).show();
				Intent RUlistIntent = new Intent(RUlistActivity.this,
						RUdetailActivity.class);
				RUlistIntent.putExtra(EXTRA_MESSAGE_RU_POSITION, position);
				RUlistIntent.putExtra(EXTRA_MESSAGE_RU_TYPE, iType);
				startActivity(RUlistIntent);

				// great animation to delete items
				// view.animate().setDuration(2000).alpha(0)
				// .withEndAction(new Runnable() {
				// public void run() {
				// list.remove(item);
				// adapter.notifyDataSetChanged();
				// view.setAlpha(1);
				// }
				// });
			}

		});
	}

	private class StableArrayAdapter extends ArrayAdapter<String> {

		HashMap<String, Integer> mIdMap = new HashMap<String, Integer>();

		public StableArrayAdapter(Context context, int textViewResourceId,
				List<String> objects) {
			super(context, textViewResourceId, objects);
			for (int i = 0; i < objects.size(); ++i) {
				mIdMap.put(objects.get(i), i);
			}
		}

		public long getItemId(int position) {
			String item = getItem(position);
			return mIdMap.get(item);
		}

		public boolean hasStableIds() {
			return true;
		}

	}
}
