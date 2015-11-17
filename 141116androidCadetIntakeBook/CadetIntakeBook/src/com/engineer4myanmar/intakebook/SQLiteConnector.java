package com.engineer4myanmar.intakebook;

import java.util.ArrayList;
import java.util.List;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
/**
* @author manish.s
* Updat by Dr. Aung Win  Htut
*/
public class SQLiteConnector {
	public String selectQueryb1 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၁)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb2 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၂)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb3 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၃)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb4 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၄)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb5 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၅)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb6 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၆)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb7 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၇)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQueryb8 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၈)တပ္ခြဲ' and bat='ဘုရင္႔ေနာင္တပ္ရင္း'";
	public String selectQuerya1 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၁)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQuerya2 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၂)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQuerya3 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၃)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQuerya4 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၄)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQuerya5 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၅)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQuerya6 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၆)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQuerya7 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၇)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	public String selectQuerya8 = "SELECT  * FROM " + TABLE_RECORD+" where com='အမွတ္(၈)တပ္ခြဲ' and bat='အေနာ္ရထာတပ္ရင္း'";
	private SQLiteDatabase database;
	private SQLiteHelper sqlHelper;
	private Cursor cursor;
	
	//You can change database *** table name *** here
	private static final String TABLE_RECORD = "cadettb";
	
	public SQLiteConnector(Context context) {
		sqlHelper = new SQLiteHelper(context);
	}
	
	// Getting All records from *** k columns *** zero base
	public List<String> getAllRecord(int iColumns) {
		List<String> studentList = new ArrayList<String>();	
		String selectQuery = "SELECT  * FROM " + TABLE_RECORD;
		database = sqlHelper.getReadableDatabase();
		cursor = database.rawQuery(selectQuery, null);
		if (cursor.moveToFirst()) {
				do {
						studentList.add(cursor.getString(iColumns));						
				} while (cursor.moveToNext());
		}
		database.close();
		return studentList;
	}
	//Getting specific records from *** k columns *** zero base depends on ***selectQuery***
		public List<String> getGroupRecord(int iColumns,String selectQuery) {
			List<String> studentList = new ArrayList<String>();				
			database = sqlHelper.getReadableDatabase();
			cursor = database.rawQuery(selectQuery, null);
			if (cursor.moveToFirst()) {
					do {
							studentList.add(cursor.getString(iColumns));						
					} while (cursor.moveToNext());
			}
			database.close();
			return studentList;
		}
				
}
