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

public class BANGLADESHlistActivity extends Activity {
	public final static String EXTRA_MESSAGE_BANGLADESH_POSITION= "com.engineer4myanmar.swp.knowledge.POSITION";
	public final static String EXTRA_MESSAGE_BANGLADESH_TYPE = "com.engineer4myanmar.swp.knowledge.TYPE";
	
	int iType=0;
	String[] BANGLADESHGUNS = new String[] { 
			"Type 59 100 mm Towed Anti-Aircraft Artillery", // 1
			"57 mm AZP S-60 Anti-Aircraft Gun", // 2
			"Bofors 40 mm Gun", // 3
			"20 mm Anti-Aircraft Gun", // 4
			"35 mm Type 90 Anti-Aircraft Gun", // 5
	};
	String[] BANGLADESHMissiles = new String[] { 
			//BANGLADESHm
			"HQ-7(FM-90) Air Defence System", // 1
			"Aster 30 SAMPT/T Medium Range Sam", // 2
			"LY-60 Surface to Air Missile System", // 3
			
	};
	String[] BANGLADESHRadars = new String[] { 
			"1L-117 Radar", // 1
			"AN/TPS-43 Radar", // 2
			"AN/TPS-43 Radar", // 3
			"P 35 M Radar", // 4
			"YLC-2 Radar", // 5
			"YLC-6 Radar (2D) ", // 6
			
	};

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);		
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		Intent intent = getIntent();
		iType = intent.getIntExtra(BangladeshActivity.EXTRA_MESSAGE_BANGLADESH, 0);
		Log.d("itype",String.valueOf(iType));
		setContentView(R.layout.activity_bangladeshlist);
		//Toast.makeText(getApplicationContext(), "OK",Toast.LENGTH_SHORT).show();
		
		final ListView listview = (ListView) findViewById(R.id.listviewBANGLADESH);
		final ArrayList<String> list = new ArrayList<String>();
		switch (iType) {
		case 1:
			for (int i = 0; i < BANGLADESHRadars.length; ++i) {
				list.add(BANGLADESHRadars[i]);
			}
			break;
		case 2:
			for (int i = 0; i < BANGLADESHGUNS.length; ++i) {
				list.add(BANGLADESHGUNS[i]);
			}
			break;
		case 3:
			for (int i = 0; i < BANGLADESHMissiles.length; ++i) {
				list.add(BANGLADESHMissiles[i]);
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
				Intent BANGLADESHlistIntent = new Intent(BANGLADESHlistActivity.this,
						BANGLADESHdetailActivity.class);
				BANGLADESHlistIntent.putExtra(EXTRA_MESSAGE_BANGLADESH_POSITION, position);
				BANGLADESHlistIntent.putExtra(EXTRA_MESSAGE_BANGLADESH_TYPE, iType);
				startActivity(BANGLADESHlistIntent);

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
