<?php

namespace app\models;

use Yii;

/**
 * This is the model class for table "zakup".
 *
 * @property integer $id
 * @property string $data_zakupu
 * @property integer $klient_id
 *
 * @property Bilet[] $bilets
 * @property Klient $klient
 */
class Zakup extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'zakup';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'data_zakupu', 'klient_id'], 'required'],
            [['id', 'klient_id'], 'integer'],
            [['data_zakupu'], 'safe']
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'data_zakupu' => 'Data Zakupu',
            'klient_id' => 'Klient ID',
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getBilets()
    {
        return $this->hasMany(Bilet::className(), ['zakup_id' => 'id']);
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getKlient()
    {
        return $this->hasOne(Klient::className(), ['id' => 'klient_id']);
    }
}
