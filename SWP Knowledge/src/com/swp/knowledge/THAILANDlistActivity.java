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

public class THAILANDlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_THAILAND_POSITION= "com.engineer4myanmar.swp.knowledge.THAILAND.POSITION";
	public final static String EXTRA_MESSAGE_THAILAND_TYPE = "com.engineer4myanmar.swp.knowledge.THAILAND.TYPE";
	
	int iType=0;
	String[] thailandGUNS = new String[] { 
			"", // 1
			
	};
	String[] thailandMissiles = new String[] { 
			//thailandm
			"ADATS (Air Defence Anti-tank system)", // 1
			"ADATS (Air Defence Anti-tank system)", // 2
			"Crotale Low Level SAM", // 3
			"RBS 70 SAM", // 4
	};
	String[] thailandRadars = new String[] { 
			"AN/TPS-78 S-Band Radar", // 1
			"AN/TPS -70 Tactical Radar", // 2
			"AN/TPS -43 Tactical Radar", // 3
			"AN/FPS-117 Radar", // 4
			"Giraaffe AME Radar", // 5
			"AN/FPS-130 X Air Surveillance Radar", // 6
			"RAT-31S Radar", // 7
		
	};

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);		
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		Intent intent = getIntent();
		iType = intent.getIntExtra(ThailandActivity.EXTRA_MESSAGE_THAILAND, 0);
		Log.d("itype",String.valueOf(iType));
		setContentView(R.layout.activity_thailandlist);
		//Toast.makeText(getApplicationContext(), "OK",Toast.LENGTH_SHORT).show();
		
		final ListView listview = (ListView) findViewById(R.id.listviewTHAILAND);
		final ArrayList<String> list = new ArrayList<String>();
		switch (iType) {
		case 1:
			for (int i = 0; i < thailandRadars.length; ++i) {
				list.add(thailandRadars[i]);
			}
			break;
		case 2:
			for (int i = 0; i < thailandGUNS.length; ++i) {
				list.add(thailandGUNS[i]);
			}
			break;
		case 3:
			for (int i = 0; i < thailandMissiles.length; ++i) {
				list.add(thailandMissiles[i]);
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
				Intent THAILANDlistIntent = new Intent(THAILANDlistActivity.this,
						THAILANDdetailActivity.class);
				THAILANDlistIntent.putExtra(EXTRA_MESSAGE_THAILAND_POSITION, position);
				THAILANDlistIntent.putExtra(EXTRA_MESSAGE_THAILAND_TYPE, iType);
				startActivity(THAILANDlistIntent);

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
