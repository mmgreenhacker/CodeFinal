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
			"85 mm Air Defense Gun M1939 (52-К)",//7
			"100 mm Air Defense Gun KS-19",//8
			
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
			"S-75 Lea / V-750 SA-2 Guideline",//9
			"Pantsir-S1",//10
			"9K37 Buk Missile System NATO Reporting Name:SA-11 Gadfly, SA-17 Grizzly",//11
			"9K38 Igla",//12
			"9K35 Strela-10",//13
			"9K34 Strela-3",//14
			"9K33 Osa (NATO Reporting Name: SA-8 Gecko)",//15
			"9K32 Strela-2 SA-7 Grail",//16
			"2K22 Tunguska (NATO Reporting Name: SA-19 Grison)",//17
			
			
	};
	String[] ruRadars = new String[] { 
			"1L13-3-1 Nebo-sv Mobile Metric-wave 2-D Radar", // 1
			"1L117M RADAR", // 2
			"1S32 (Pat Hand) H-band Fire Control and Guidance Radar(NATO Code SA-4 Ganef)", // 3
			"5N84AE Oborona-14 Mobile Metric-band 2-D Radar", // 4
			"96L6E RADAR" ,// 5
			"GAMMA-S1E RADAR", // 6
			"GAMMA-DE Radar", // 7
			"Gazetchik Equipment For Radar Protection Against Antiradar Missiles", // 8
			"KASTA-2E2 Radar", // 9
			"KASTA-2E1 RADAR" ,// 10
			"P-18-2 Mobile Metric-wave 2-d Radar", // 11
			"P-40 1S12 Long Track 3D UH Early Warning & Acquisition Radar (NATO reporting name - Long Track)", // 12
			"PROTIVNIK-GE Radar", // 13
			"PRV-9 1RL19 Thin Skin E Band Heigh Finding Radar", // 14
			
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
