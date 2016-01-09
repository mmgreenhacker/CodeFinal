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

public class ISRAELlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_ISRAEL_POSITION= "com.engineer4myanmar.swp.knowledge.ISRAEL.POSITION";
	public final static String EXTRA_MESSAGE_ISRAEL_TYPE = "com.engineer4myanmar.swp.knowledge.ISRAEL.TYPE";
	
	int iType=0;
	String[] israelGUNS = new String[] { 
			"37 mm Gun M1", // 1
			"90 mm Gun M1A1", // 2
			"Bofors 40 mm gun", // 3
			"Oerlikon 20 mm cannon", // 4
			"120 mm M1 gun" // 5
	};
	String[] israelMissiles = new String[] { 
			//israelm
			"RIM – 2 Terrier", // 1
			"Nike Ajax", // 2
			"Nike Hercules", // 3
			"RIM-8 Talos", // 4
			"CIM-10 Bomarc", // 5
			"MIM-23 Hawk", // 6
			"RIM-24 Tartar", // 7
			"FIM-43 Redeye", // 8
			"RIM-50 Typhon", // 9
			"RIM-7 Sea Sparrow", // 10			
			"MIM-72 Chaparral", // 11
			"RIM-67 Standard ER", // 12
			"RIM-66 Standard", // 13
			"FIM-92 Stinger", // 14
			"AN/TWQ-1 Avenger", // 15
			"MIM-104 Patriot", // 16
			"Patriot missile", // 17
			"Roland (missile)", // 18
			"RIM-116 Rolling Airframe Missile", // 19
			"RIM-67 Standard ER", // 20
			"RIM-162 ESSM", // 21
			"LAV-25" // 22
	};
	String[] israelRadars = new String[] { "R1", // 1
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
		iType = intent.getIntExtra(IsraelActivity.EXTRA_MESSAGE_ISRAEL, 0);
		Log.d("itype",String.valueOf(iType));
		setContentView(R.layout.activity_israellist);
		//Toast.makeText(getApplicationContext(), "OK",Toast.LENGTH_SHORT).show();
		
		final ListView listview = (ListView) findViewById(R.id.listviewISRAEL);
		final ArrayList<String> list = new ArrayList<String>();
		switch (iType) {
		case 1:
			for (int i = 0; i < israelRadars.length; ++i) {
				list.add(israelRadars[i]);
			}
			break;
		case 2:
			for (int i = 0; i < israelGUNS.length; ++i) {
				list.add(israelGUNS[i]);
			}
			break;
		case 3:
			for (int i = 0; i < israelMissiles.length; ++i) {
				list.add(israelMissiles[i]);
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
				Intent ISRAELlistIntent = new Intent(ISRAELlistActivity.this,
						ISRAELdetailActivity.class);
				ISRAELlistIntent.putExtra(EXTRA_MESSAGE_ISRAEL_POSITION, position);
				ISRAELlistIntent.putExtra(EXTRA_MESSAGE_ISRAEL_TYPE, iType);
				startActivity(ISRAELlistIntent);

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
