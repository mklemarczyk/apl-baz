<?php

namespace app\models;

use Yii;

/**
 * This is the model class for table "lot".
 *
 * @property integer $id
 * @property string $numer_lotu
 * @property string $data_wylotu
 * @property integer $czas_lotu
 * @property integer $samolot_id
 * @property integer $lotnisko_start
 * @property integer $lotnisko_end
 *
 * @property Bilet[] $bilets
 * @property Samolot $samolot
 * @property Lotnisko $lotniskoStart
 * @property Lotnisko $lotniskoEnd
 */
class Lot extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'lot';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'numer_lotu', 'data_wylotu', 'czas_lotu', 'samolot_id', 'lotnisko_start', 'lotnisko_end'], 'required'],
            [['id', 'czas_lotu', 'samolot_id', 'lotnisko_start', 'lotnisko_end'], 'integer'],
            [['data_wylotu'], 'safe'],
            [['numer_lotu'], 'string', 'max' => 20]
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'numer_lotu' => 'Numer Lotu',
            'data_wylotu' => 'Data Wylotu',
            'czas_lotu' => 'Czas Lotu',
            'samolot_id' => 'Samolot ID',
            'lotnisko_start' => 'Lotnisko Start',
            'lotnisko_end' => 'Lotnisko End',
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getBilets()
    {
        return $this->hasMany(Bilet::className(), ['lot_id' => 'id']);
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getSamolot()
    {
        return $this->hasOne(Samolot::className(), ['id' => 'samolot_id']);
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getLotniskoStart()
    {
        return $this->hasOne(Lotnisko::className(), ['id' => 'lotnisko_start']);
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getLotniskoEnd()
    {
        return $this->hasOne(Lotnisko::className(), ['id' => 'lotnisko_end']);
    }
}
