<?php

namespace app\models;

use Yii;

/**
 * This is the model class for table "lotnisko".
 *
 * @property integer $id
 * @property string $nazwa
 * @property string $miasto
 * @property string $kraj
 *
 * @property Lot[] $lots
 */
class Lotnisko extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'lotnisko';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'nazwa', 'miasto', 'kraj'], 'required'],
            [['id'], 'integer'],
            [['nazwa', 'miasto', 'kraj'], 'string', 'max' => 50]
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'nazwa' => 'Nazwa',
            'miasto' => 'Miasto',
            'kraj' => 'Kraj',
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getLots()
    {
        return $this->hasMany(Lot::className(), ['lotnisko_end' => 'id']);
    }
}
