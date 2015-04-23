<?php

namespace frontend\models;

use Yii;
use yii\base\Model;
use yii\data\ActiveDataProvider;
use common\models\Samolot;

/**
 * SamolotSearch represents the model behind the search form about `common\models\Samolot`.
 */
class SamolotSearch extends Samolot
{
    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'liczba_miejsc'], 'integer'],
            [['model', 'rok_produkcji'], 'safe'],
        ];
    }

    /**
     * @inheritdoc
     */
    public function scenarios()
    {
        // bypass scenarios() implementation in the parent class
        return Model::scenarios();
    }

    /**
     * Creates data provider instance with search query applied
     *
     * @param array $params
     *
     * @return ActiveDataProvider
     */
    public function search($params)
    {
        $query = Samolot::find();

        $dataProvider = new ActiveDataProvider([
            'query' => $query,
        ]);

        $this->load($params);

        if (!$this->validate()) {
            // uncomment the following line if you do not want to any records when validation fails
            // $query->where('0=1');
            return $dataProvider;
        }

        $query->andFilterWhere([
            'id' => $this->id,
            'rok_produkcji' => $this->rok_produkcji,
            'liczba_miejsc' => $this->liczba_miejsc,
        ]);

        $query->andFilterWhere(['like', 'model', $this->model]);

        return $dataProvider;
    }
}
