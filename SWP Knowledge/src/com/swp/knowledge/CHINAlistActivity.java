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

public class CHINAlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_CHINA_POSITION= "com.engineer4myanmar.swp.knowledge.CHINA.POSITION";
	public final static String EXTRA_MESSAGE_CHINA_TYPE = "com.engineer4myanmar.swp.knowledge.CHINA.TYPE";
	
	int iType=0;
	String[] chinaGUNS = new String[] { 
			"35mm 8x8 Self-propelled Anti-aircraft Cannon", // 1
			"PGZ-07 twin 35mm self-propelled anti-aircraft gun", // 2
			"PGZ-04A PGZ95", // 3
			"Type 63 anti-aircraft gun", // 4
			"Type 95 SPAAA (PGZ95) 25 mm" // 5
	};
	String[] chinaMissiles = new String[] { 
			//chinam
			"SC-19",//1
			"KT-1 (Kaituozhe-1), KT-2, KT-3  (Anti-satellite missile)", // 2
			"Fan Ji (Anti-Ballistic Missile)", // 3
			"HQ-18/15 (Anti-Ballistic Missile)", // 4
			"S-300 PMU2", // 5
			"S-300 PMU1 (HQ-10)", // 6
			"HQ-9 Surface to Air Missile (FT-200)", // 7
			"KS-1000 Missile", // 8
			"Kai Shan - 1 (KS-1)", // 9
			"HQ-12/KS-2", // 10
			"FT-2000", // 11			
			"Sky Dragon", // 12
			"FD-2000", // 13
			"S-300 PMU", // 14
			"HQ-16", // 15
			"Tor-M1", // 16
			"HQ-7 (FM-B0)", // 17
			"HQ-6" // 18
		
	};
	String[] chinaRadars = new String[] { 
			"YLC-2/YLC-2A/YLC-2V", // 1
			"YLC-2", // 2
			"YLC-6M", // 3
			"YLC-18 (3D)" // 4
			
	};

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);		
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		Intent intent = getIntent();
		iType = intent.getIntExtra(ChinaActivity.EXTRA_MESSAGE_CHINA, 0);
		Log.d("itype",String.valueOf(iType));
		setContentView(R.layout.activity_chinalist);
		//Toast.makeText(getApplicationContext(), "OK",Toast.LENGTH_SHORT).show();
		
		final ListView listview = (ListView) findViewById(R.id.listviewCHINA);
		final ArrayList<String> list = new ArrayList<String>();
		switch (iType) {
		case 1:
			for (int i = 0; i < chinaRadars.length; ++i) {
				list.add(chinaRadars[i]);
			}
			break;
		case 2:
			for (int i = 0; i < chinaGUNS.length; ++i) {
				list.add(chinaGUNS[i]);
			}
			break;
		case 3:
			for (int i = 0; i < chinaMissiles.length; ++i) {
				list.add(chinaMissiles[i]);
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
				Intent CHINAlistIntent = new Intent(CHINAlistActivity.this,
						CHINAdetailActivity.class);
				CHINAlistIntent.putExtra(EXTRA_MESSAGE_CHINA_POSITION, position);
				CHINAlistIntent.putExtra(EXTRA_MESSAGE_CHINA_TYPE, iType);
				startActivity(CHINAlistIntent);

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
