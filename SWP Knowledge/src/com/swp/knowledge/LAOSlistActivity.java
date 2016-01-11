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

public class LAOSlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_LAOS_POSITION= "com.engineer4myanmar.swp.knowledge.POSITION";
	public final static String EXTRA_MESSAGE_LAOS_TYPE = "com.engineer4myanmar.swp.knowledge.TYPE";
	
	int iType=0;
	String[] laosGUNS = new String[] { 
			"57 mm S-60", // 1
			"37 mm M1939", // 2
			"23 mm ZSU 23-4", // 3
			"14.5 mm ZPU-1", // 4
			"14.5 mm ZPU-2" // 5
	};
	String[] laosMissiles = new String[] { 
			//laosm
			"SA-3 Goa Surface To Air Missile", // 1
			"SA-7 A/B Grail Man Pad Missile", // 2
			"AA-2 (Atoll) Air to Air Missile" // 3		
	};
	String[] laosRadars = new String[] { 
			"" // 1
		
	};

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);		
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		Intent intent = getIntent();
		iType = intent.getIntExtra(LaosActivity.EXTRA_MESSAGE_LAOS, 0);
		Log.d("itype",String.valueOf(iType));
		setContentView(R.layout.activity_laoslist);
		//Toast.makeText(getApplicationContext(), "OK",Toast.LENGTH_SHORT).show();
		
		final ListView listview = (ListView) findViewById(R.id.listviewLAOS);
		final ArrayList<String> list = new ArrayList<String>();
		switch (iType) {
		case 1:
			for (int i = 0; i < laosRadars.length; ++i) {
				list.add(laosRadars[i]);
			}
			break;
		case 2:
			for (int i = 0; i < laosGUNS.length; ++i) {
				list.add(laosGUNS[i]);
			}
			break;
		case 3:
			for (int i = 0; i < laosMissiles.length; ++i) {
				list.add(laosMissiles[i]);
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
				Intent LAOSlistIntent = new Intent(LAOSlistActivity.this,
						LAOSdetailActivity.class);
				LAOSlistIntent.putExtra(EXTRA_MESSAGE_LAOS_POSITION, position);
				LAOSlistIntent.putExtra(EXTRA_MESSAGE_LAOS_TYPE, iType);
				startActivity(LAOSlistIntent);

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
