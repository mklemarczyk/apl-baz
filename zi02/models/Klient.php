<?php

namespace app\models;

use Yii;

/**
 * This is the model class for table "klient".
 *
 * @property integer $id
 * @property string $imie
 * @property string $nazwisko
 * @property integer $user_id
 *
 * @property Zakup[] $zakups
 */
class Klient extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'klient';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'imie', 'nazwisko', 'user_id'], 'required'],
            [['id', 'user_id'], 'integer'],
            [['imie', 'nazwisko'], 'string', 'max' => 255]
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'imie' => 'Imie',
            'nazwisko' => 'Nazwisko',
            'user_id' => 'User ID',
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getZakups()
    {
        return $this->hasMany(Zakup::className(), ['klient_id' => 'id']);
    }
}
